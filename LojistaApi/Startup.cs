using System;
using System.IO;
using System.Reflection;
using LojistaApi.AcessoDados;
using LojistaApi.AcessoDados.Interface;
using LojistaApi.Negocio;
using LojistaApi.Negocio.Interfaces;
using LojistaApi.Servicos;
using LojistaApi.Servicos.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace LojistaApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddHttpClient();

            services.AddSingleton<ISolicitacaoNegocio, SolicitacaoNegocio>();
            services.AddSingleton<ISolicitacaoRepositorio, SolicitacaoRepositorio>();
            services.AddSingleton<IAtacadistaApi, AtacadistaApi>();
            services.AddSingleton<IOrcamentoNegocio, OrcamentoNegocio>();
            services.AddSingleton<IOrcamentoRepositorio, OrcamentoRepositorio>();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "Api de lojista", Version = "v1" });
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            // Enable middleware to serve generated Swagger as a JSON endpoint.
            app.UseSwagger();

            // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
            // specifying the Swagger JSON endpoint.
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Gestão de Livraria");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
