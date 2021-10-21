using _Spider.Entidades;
using Refit;
using System.Threading.Tasks;

namespace RefitCepExample
{
    public interface ICnpjApiService
    {
        [Get("/v1/cnpj/{cnpj}")]
        Task <Spider_2> GetDataAsync(string cnpj);
    }
}
