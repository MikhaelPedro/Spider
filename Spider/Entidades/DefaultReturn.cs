using System;
using System.Collections.Generic;
using System.Text;

namespace Spider.Entidades
{
    public class DefaultReturn
    {
        public string Texto { get; set; }

        public DefaultReturn()
        {

        }

        public DefaultReturn(string texto)
        {
            Texto = texto;
        }

        //Menu
        public string Menu()
        {
            return $"        |----------------------------------------------------------|\n" +
                $"        | Digite Qual Spider você deseja utilizar:                 |\n" +
                $"        | Digite 1 para o 1° Spider:                               |\n" +
                $"        | Digite 2 para o 2° Spider:                               |\n"+
                $"        | Digite Exit, para encerrar o processo:                   |\n" +
                $"        |----------------------------------------------------------|\n";
        }

        //Spider 1 Cabecalho
        public string Spider1Cabecalho()
        {
            return $"        |----------------------------------------------------------|\n" +
                $"        |                   Voce esta no Spider 1!                 |\n" +
                $"        |----------------------------------------------------------|\n";
        }

        //Spider 2 Cabecalho
        public string Spider2Cabecalho()
        {
            return $"        |----------------------------------------------------------|\n" +
                $"        |                   Voce esta no Spider 2!                 |\n" +
                $"        |----------------------------------------------------------|\n";
        }
        //Retorno comando invalido
        public string ComandoInvalido()
        {
            return $"        |----------------------------------------------------------|\n" +
                $"        | Comando inválido, favor digitar seu comando novamente    |\n" +
                $"        |----------------------------------------------------------|\n";
        }
        // Retorno fim da consulta
        public string FimdaConsulta()
        {
            return $"        |----------------------------------------------------------|\n" +
                $"        |                        FIM DA CONSULTA                   |\n" +
                $"        |----------------------------------------------------------|\n";
        }

        //public static string removerAcentos(string texto)
        //{
        //    string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
        //    string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

        //    for (int i = 0; i < comAcentos.Length; i++)
        //    {
        //        texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
        //    }
        //    return texto;
        //}
    }
}
