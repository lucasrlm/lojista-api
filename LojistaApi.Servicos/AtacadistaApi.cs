using LojistaApi.Model.Solicitacao;
using LojistaApi.Servicos.Interface;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;

namespace LojistaApi.Servicos
{
    public class AtacadistaApi : IAtacadistaApi
    {
        private readonly IConfiguration _configuracao;

        private readonly HttpClient _clienteHttp;

        public AtacadistaApi(IConfiguration configuracao)
        {
            _configuracao = configuracao;
            _clienteHttp = new HttpClient()
            {
                BaseAddress = new Uri(_configuracao.GetSection("Apis:AtacadistaApi").Value)
            };
        }

        public int CriarSolicitacao(Solicitacao solicitacao)
        {
            var json = JsonConvert.SerializeObject(solicitacao);

            var response = _clienteHttp.PostAsync("", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                var contents = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<int>(contents);          
            }
            else
            {
                throw new Exception("Erro na chamada da API de atacadista.");                
            }
        }

        public void AlterarSolicitacao(int solicitacaoId, Solicitacao solicitacao)
        {
            var json = JsonConvert.SerializeObject(solicitacao);

            var response = _clienteHttp.PutAsync($"/{solicitacaoId}", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro na chamada da API de atacadista.");          
            }
        }
    }
}
