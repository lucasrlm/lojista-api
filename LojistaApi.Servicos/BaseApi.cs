using System;
using System.Net.Http;

namespace LojistaApi.Servicos
{
    public class BaseApi
    {
        public Uri BaseUrl;

        public HttpClient HttpClient;

        public BaseApi(string baseUrl)
        {
            HttpClient = new HttpClient()
            {
                BaseAddress = new Uri(baseUrl)
            };
        }
    }
}
