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
            //int i = 0;
            //Iniciando Classes de retorno
            DefaultReturn defaultReturn = new DefaultReturn();
            DefaultReturnBase defaultReturnBase = new DefaultReturnBase("");
            //DateTime Id = new DateTime();

            //Enquanto o comando do user for diferente de exit faça
            while (Aux == 0)
            {    
                //Para renomear o Arquivo com essas propriedades
                var id = DateTime.Now.Ticks;
                string now = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                now = now.Replace('/', '-');
                now = now.Replace(':', '-');

                //Datetime.parse(DateTime.Now.Ticks);
                //C: \\Users\\mikhael.molina\\OneDrive - REPLACE PROJETOS E CONSULTORIA EM ENERGIA LTDA\\Área de Trabalho\\Spider\\
                //C:\Users\Mikhael Pedro\Desktop\Spider
                //C:\\Users\\Mikhael Pedro\\Desktop\\Spider\\

                //Caminho do arquivo e nome do Arquivo usando as propridades acima 
                string path = "C: \\Users\\mikhael.molina\\OneDrive - REPLACE PROJETOS E CONSULTORIA EM ENERGIA LTDA\\Área de Trabalho\\Spider\\" + "Backup - Data [" + now + "] Id - " + id.ToString() + ".txt";
                
                //Verifica se o caminho já existe
                FileInfo aFile = new FileInfo(path);
                bool verifica = aFile.Exists;
                if (verifica != false)
                {
                    Console.WriteLine("          O Arquivo especificado ja existe");
                    aFile.Refresh();
                }

                //Classe que escreve no arquivo
                StreamWriter valor = new StreamWriter(path, true, Encoding.ASCII);

                //Retorno da classe defaultReturn e input da acao
                Console.WriteLine(defaultReturn.Menu()); 
                Console.Write("          Comando: ");
                string acao = Console.ReadLine();
                acao = acao.ToLower();
                
                switch (acao)
                {
                    case "1":

                        //Texto Menu
                        Console.WriteLine(defaultReturn.Spider1Cabecalho());

                        //Tratamento do dado, envio da Consulta e retorno da consulta
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

                            //Recebe o retorno da API e chama o metodo para retirar acentuacoes e grava no arquivo txt
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

                        //Tratamento do dado, envio da Consulta e retorno da consulta
                        Console.WriteLine(defaultReturn.Spider2Cabecalho());

                        Console.Write("          Digite o CNPJ: ");
                        string cnpj = Console.ReadLine();
                        var cnpjClient = RestService.For<ICnpjApiService>("https://www.receitaws.com.br");
                        Console.WriteLine();
                        Console.WriteLine("          Consultando dados do CNPJ:" + cnpj + "...\n");
                        var data = await cnpjClient.GetDataAsync(cnpj);
                        Console.WriteLine(data.ToString());
                        valor.WriteLine(defaultReturn.Spider2Cabecalho());
                        //Recebe o retorno da API e chama o metodo para retirar acentuacoes e grava no arquivo txt
                        defaultReturnBase.removerAcentos(data.ToString());
                        valor.WriteLine(defaultReturnBase.Texto);
                        valor.Close();
                        break;

                    case "exit":

                        //Fim da aplicacao e Retorno no arquivo txt
                        Aux = 1;
                        Console.WriteLine(defaultReturn.FimdaConsulta());
                        valor.WriteLine(defaultReturn.FimdaConsulta());
                        valor.Close();
                        break;
                    default:
                        //Comando invalido e Retorno no arquivo txt
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