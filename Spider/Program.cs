using System;

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
                Console.WriteLine("        |------------------------------------------|");
                Console.WriteLine("        | Digite Qual Spider você deseja utilizar: |");
                Console.WriteLine("        | Digite 1 para o 1° Spider:               |");
                Console.WriteLine("        | Digite 2 para o 2° Spider:               |");
                Console.WriteLine("        | Digite Exit, para encerrar o processo:   |");
                Console.WriteLine("        |------------------------------------------|");
                Console.Write("        | Comando: ");
                string acao = Console.ReadLine();

                switch (acao)
                {
                    case "1":
                        Console.WriteLine("        | Você está no Spider 1");
                        break;
                    case "2":
                        Console.WriteLine("        | Você está no Spider 2");
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
            Console.WriteLine("        |------------------------------------------|");
        }
    }
}
