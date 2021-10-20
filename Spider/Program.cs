using Refit;
using RefitCepExample;
using System;
using System.Threading.Tasks;

namespace _Spider
{ 
    class Program
    {
        static async Task Main(string[] args)
        {
            int Aux = 0;

            while (Aux == 0)
            {


                Console.WriteLine();
                Console.WriteLine("        |----------------------------------------------------------|");
                Console.WriteLine("        | Digite Qual Spider você deseja utilizar:                 |");
                Console.WriteLine("        | Digite 1 para o 1° Spider:                               |");
                Console.WriteLine("        | Digite 2 para o 2° Spider:                               |");
                Console.WriteLine("        | Digite Exit, para encerrar o processo:                   |");
                Console.WriteLine("        |----------------------------------------------------------|");
                Console.Write("          Comando: ");
                string acao = Console.ReadLine();
                acao = acao.ToLower();
                switch (acao)
                {
                    case "1":
                        //Texto de Apresentação do Modulo E o Input
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        |                   Você está no Spider 1!                 |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.Write("          Digite o CEP: ");

                        //Tratamento do dado e envio da Consulta
                        string cep = Console.ReadLine();
                        var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                        Console.WriteLine();
                        Console.WriteLine("          Consultando dados do Cep:" + cep + "...\n");
                        var address = await cepClient.GetAddressAsync(cep);
                        Console.WriteLine(address.ToString());

                        break;
                    case "2":
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        |                   Você está no Spider 2!                 |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.Write("          Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();

                        break;
                    case "exit":
                        Aux = 1;
                        break;
                    default:
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        | Comando inválido, favor digitar seu comando novamente    |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        break;

                }
            }
            Console.WriteLine("        |----------------------------------------------------------|");
            Console.WriteLine("        |                       FÌM DA CONSULTA                    |");
            Console.WriteLine("        |----------------------------------------------------------|");
        }       
    }
}