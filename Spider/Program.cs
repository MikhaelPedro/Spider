using System;

namespace Spider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("|------------------------------------------|");
            Console.WriteLine("| Digite Qual Spider você deseja utilizar: |");
            Console.WriteLine("| Digite 1 para o 1° Spider:               |");
            Console.WriteLine("| Digite 2 para o 2° Spider:               |");
            Console.WriteLine("| Digite Exit, para encerrar o processo:   |");
            Console.WriteLine("|------------------------------------------|");
            Console.Write("| Comando: ");
            string acao = Console.ReadLine();
            if(acao != "Exit" )
            {  
                if (acao == "1")
                {
                    Console.WriteLine("| Você está no Spider 1");
                }
                else if (acao == "2")
                {
                    Console.WriteLine("| Você está no Spider 2");
                }
                else
                {
                    Console.WriteLine("| Comando inválido, favor digitar seu comando novamente");
                }
            }
            Console.WriteLine("|------------------------------------------|");

        }
    }
}
