using LojistaApi.Model;
using LojistaApi.Model.Solicitacao;
using LojistaApi.Servicos.Interface;
using LojistaApi.Util;
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

        public RetornoBase CriarSolicitacao(Solicitacao solicitacao)
        {
            var json = JsonConvert.SerializeObject(solicitacao);

            var response = _clienteHttp.PostAsync("", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (response.IsSuccessStatusCode)
            {
                var contents = response.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<RetornoBase>(contents);          
            }
            else
            {
                throw new Exception("Erro na chamada da API de atacadista.");                
            }
        }

        public void AlterarSolicitacao(int solicitacaoId, SolicitacaoStatus solicitacaoStatus)
        {
            var json = JsonConvert.SerializeObject(solicitacaoStatus);

            var response = _clienteHttp.PutAsync(_clienteHttp.BaseAddress + $"/{solicitacaoId}", new StringContent(json, Encoding.UTF8, "application/json")).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Erro na chamada da API de atacadista.");          
            }
        }
    }
}
