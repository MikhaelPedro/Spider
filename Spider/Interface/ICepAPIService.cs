using _Spider.Entidades;
using Refit;
using System.Threading.Tasks;

namespace RefitCepExample
{
    public interface ICepApiService
    {
        [Get("/ws/{cep}/json")]
        Task<Spider_1> GetAddressAsync(string cep);
    }
}
