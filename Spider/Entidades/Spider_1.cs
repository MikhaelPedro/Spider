using System;
using System.Collections.Generic;
using System.Text;

namespace Spider.Entidades
{
    public class Spider_1
    {
        public string CEP { get; set; }
        public string Logradouro{ get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }

        public override string ToString()
        {
            return string.Format($"{CEP} - {Logradouro}");
        }
        //public Spider_1(string cep)
        //{
        //    CEP = cep;
        //}

        //public void ADDCEP(string cep)
        //{
        //    CEP = cep + "1";
        //}
    }
}
