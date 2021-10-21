using Refit;
using RefitCepExample;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace _Spider
{ 
    class Program
    {
        static async Task Main(string[] args)
        {
            int Aux = 0;
            int i = 0;

            while (Aux == 0)
            {
                

                FileInfo aFile = new FileInfo("C:\\Users\\Mikhael Pedro\\Desktop\\" + "Backup" + i.ToString() + ".txt");
                bool verifica = aFile.Exists;
                if(verifica != false)
                {
                    aFile.Delete();
                }
                string path = "C:\\Users\\Mikhael Pedro\\Desktop\\" + "Backup" + i.ToString() + ".txt";

                StreamWriter valor = new StreamWriter(path, true, Encoding.ASCII);
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
                        Console.WriteLine("          Consultando dados do CEP:" + cep + "...\n");
                        try
                        {
                            var address = await cepClient.GetAddressAsync(cep);
                            Console.WriteLine(address.ToString());
                            valor.WriteLine(address.ToString());
                            valor.Close();
                        }
                        catch
                        {
                            Console.WriteLine("          CEP Inválido!\n");
                        }                        
                        break;

                    case "2":
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.WriteLine("        |                   Você está no Spider 2!                 |");
                        Console.WriteLine("        |----------------------------------------------------------|");
                        Console.Write("          Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();
                        var cnpjClient = RestService.For<ICnpjApiService>("https://www.receitaws.com.br");
                        Console.WriteLine();
                        Console.WriteLine("          Consultando dados do CNPJ:" + cnpj + "...\n");
                        var data = await cnpjClient.GetDataAsync(cnpj);
                        Console.WriteLine(data.ToString());
                        valor.WriteLine(data.ToString());
                        valor.Close();
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
                i++;
            }
            Console.WriteLine("        |----------------------------------------------------------|");
            Console.WriteLine("        |                       FIM DA CONSULTA                    |");
            Console.WriteLine("        |----------------------------------------------------------|");
        }       
    }
}