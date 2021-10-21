using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace _Spider.Entidades
{
    public class Spider_2
    {
        [JsonProperty("cnpj")]
        public string CNPJ { get; set; }
        [JsonProperty("nome")]
        public string Nome { get; set; }
        [JsonProperty("email")]
        public string Email { get; set; }
        [JsonProperty("telefone")]
        public string Telefone { get; set; }
        [JsonProperty("capital social")]
        public string Capital_Social { get; set; }
        [JsonProperty("municipio")]
        public string Municipio { get; set; }
        [JsonProperty("uf")]
        public string UF { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }

        public override string ToString()
        {
            if (Status != "ERROR")
            {
                return $"          CNPJ: {CNPJ}\n" +
                $"          Nome: {Nome}\n" +
                $"          Email: {Email}\n" +
                $"          Telefone: {Telefone}\n" +
                $"          Capital Social: {Capital_Social}\n" +
                $"          Municipio: {Municipio}\n" +
                $"          UF: {UF}\n";
            }
            else
                return $"          CNPJ Inválido!\n";           
        }
    }
}
