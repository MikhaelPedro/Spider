using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Spider.Entidades
{
    public class SpiderRepositorio
    {
        HttpClient cliente = new HttpClient();
        private string cep;

        public SpiderRepositorio(string cep)
        {
            this.cep = cep;
        }

        public void usuarioRepositorio()
        {
            cliente.BaseAddress = new Uri("https://viacep.com.br/ws/");

            cliente.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("/json"));
        }

        public async Task<List<Spider_1>> GetSpidersAsync(string cep)
        {
            HttpResponseMessage response = await cliente.GetAsync(cep + "/json");
            if(response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Spider_1>>(dados);
            }
            return new List<Spider_1>();
        }
    }
}
