using Newtonsoft.Json;

namespace _Spider.Entidades
{
    public class Spider_1
    {
        [JsonProperty("cep")]
        public string Cep { get; set; }
        [JsonProperty("logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty("complemento")]
        public string Complemento { get; set; }
        [JsonProperty("bairro")]
        public string Bairro { get; set; }
        [JsonProperty("localidade")]
        public string Localidade { get; set; }
        [JsonProperty("uf")]
        public string Uf { get; set; }
        [JsonProperty("unidade")]
        public string Unidade { get; set; }
        [JsonProperty("ibge")]
        public string Ibge { get; set; }
        [JsonProperty("gia")]
        public string Gia { get; set; }


        //Retorno da Consulta
        public override string ToString()
        {
            return $"          CEP: {Cep}\n" +
                $"          Logradouro: {Logradouro}\n" +
                $"          Bairro: {Bairro}\n" +
                $"          Localidade: {Localidade}\n";
        }
    }
}
//Console.Write($"\nLogradouro:{address.Logradouro}\nBairro:{address.Bairro}" +
//                            $"\nEstado:{address.Uf}\nCódigo Ibge:{address.Ibge}");