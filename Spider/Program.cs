using Spider.Entidades;
using System;
using System.Threading.Tasks;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
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
                Console.Write("        | Comando: ");
                string acao = Console.ReadLine();

                switch (acao)
                {
                    case "1":
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        |                   Você está no Spider 1!                 |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.Write("        | Digite o CEP: ");
                        string cep = Console.ReadLine();
                        //Spider_1 spider_1 = new Spider_1(cep);
                        //spider_1.ADDCEP(cep);
                        //Console.WriteLine(spider_1.CEP);
                        var repositorio = new SpiderRepositorio(cep);

                        var usuarioTask = repositorio.GetSpidersAsync(cep);
                        usuarioTask.ContinueWith(task =>
                        {
                            System.Collections.Generic.List<Spider_1> usuario = task.Result;
                            foreach (var u in usuario)
                                Console.WriteLine(u.ToString());
                            Environment.Exit(0);

                        },
                        TaskContinuationOptions.OnlyOnRanToCompletion
                        );
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        |                   Você está no Spider 2!                 |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.Write("        | Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();

                        break;
                    case "exit":
                    case "Exit":
                    case "EXIT":
                        Aux = 1;
                        //Console.WriteLine("|------------------------------------------|");

                        break;
                    default:
                        Console.WriteLine("        | Comando inválido, favor digitar seu comando novamente");
                        break;

                }
            }
            Console.WriteLine("        |----------------------------------------------------------|");
        }
    }
}
