namespace Spider.Entidades
{
    public class SpiderRepositorioBase
    {

        public async Task<List<Spider_1>> GetUsuarios(string cep)
        {
            HttpResponseMessage response = await cliente.GetAsync(cep + "/json");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<Spider_1>>(dados);
            }
            return new List<Spider_1>();
        }
    }
}