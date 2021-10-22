using Refit;
using RefitCepExample;
using System;
using System.Threading.Tasks;
using System.IO;
using System.Text;
using Spider.Entidades;

namespace _Spider
{ 
    class Program
    {
        static async Task Main(string[] args)
        {
            int Aux = 0;
            int i = 0;
            DefaultReturn defaultReturn = new DefaultReturn();
            DefaultReturnBase defaultReturnBase = new DefaultReturnBase("");
            //DateTime Id = new DateTime();
            while (Aux == 0)
            {                
                var id = DateTime.Now.Ticks;
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                now = now.Replace('/', '-');
                now = now.Replace(':', '-');

                //Datetime.parse(DateTime.Now.Ticks);
                //C: \Users\mikhael.molina\OneDrive - REPLACE PROJETOS E CONSULTORIA EM ENERGIA LTDA\Área de Trabalho\Spider
                //C:\Users\Mikhael Pedro\Desktop\Spider                
                string path = "C:\\Users\\Mikhael Pedro\\Desktop\\Spider\\" + "Backup - Data [" + now + "] Id - " + id.ToString() + ".txt";
                            
                FileInfo aFile = new FileInfo(path);
                bool verifica = aFile.Exists;
                if (verifica != false)
                {
                    Console.WriteLine("          O Arquivo especificado ja existe");
                    aFile.Refresh();
                }

                StreamWriter valor = new StreamWriter(path, true, Encoding.ASCII);

                Console.WriteLine(defaultReturn.Menu()); 
                Console.Write("          Comando: ");
                string acao = Console.ReadLine();
                acao = acao.ToLower();
                
                switch (acao)
                {
                    case "1":

                        Console.WriteLine(defaultReturn.Spider1Cabecalho());

                        //Tratamento do dado e envio da Consulta
                        Console.Write("          Digite o CEP: ");
                        string cep = Console.ReadLine();
                        var cepClient = RestService.For<ICepApiService>("https://viacep.com.br");
                        Console.WriteLine();
                        Console.WriteLine("          Consultando dados do CEP:" + cep + "...\n");
                        try
                        {
                            var address = await cepClient.GetAddressAsync(cep);
                            valor.WriteLine(defaultReturn.Spider1Cabecalho());
                            Console.WriteLine(address.ToString());
                            defaultReturnBase.removerAcentos(address.ToString());
                            valor.WriteLine(defaultReturnBase.Texto);
                            valor.Close();
                        }
                        catch
                        {
                            Console.WriteLine("          CEP Inválido!\n");
                        }                        
                        break;

                    case "2":

                        Console.WriteLine(defaultReturn.Spider2Cabecalho());

                        Console.Write("          Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();
                        var cnpjClient = RestService.For<ICnpjApiService>("https://www.receitaws.com.br");
                        Console.WriteLine();
                        Console.WriteLine("          Consultando dados do CNPJ:" + cnpj + "...\n");
                        var data = await cnpjClient.GetDataAsync(cnpj);
                        Console.WriteLine(data.ToString());
                        valor.WriteLine(defaultReturn.Spider2Cabecalho());
                        defaultReturnBase.removerAcentos(data.ToString());
                        valor.WriteLine(defaultReturnBase.Texto);
                        valor.Close();
                        break;

                    case "exit":
                        Aux = 1;
                        Console.WriteLine(defaultReturn.FimdaConsulta());
                        valor.WriteLine(defaultReturn.FimdaConsulta());
                        valor.Close();
                        break;
                    default:
                        Console.WriteLine(defaultReturn.ComandoInvalido()); 
                        valor.WriteLine(defaultReturn.ComandoInvalido());
                        valor.Close();
                        break;

                        
                }
                //i++;
                
            }
            
            //Console.WriteLine("        |----------------------------------------------------------|");
            //Console.WriteLine("        |                       FIM DA CONSULTA                    |");
            //Console.WriteLine("        |----------------------------------------------------------|");
        }       
    }
}