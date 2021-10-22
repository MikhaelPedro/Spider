using _Spider.Entidades;
using Refit;
using System.Threading.Tasks;

namespace RefitCepExample
{
    //Recebe o input cnpj e envia o caminho com o cnpj como parametro
    public interface ICnpjApiService
    {
        [Get("/v1/cnpj/{cnpj}")]
        Task <Spider_2> GetDataAsync(string cnpj);
    }
}
