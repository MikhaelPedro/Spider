using _Spider.Entidades;
using Refit;
using System.Threading.Tasks;

namespace RefitCepExample
{
    //Recebe o input cep e envia o caminho com o cep como parametro
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<Spider_1> GetAddressAsync(string cep);
    }
}
