using Fiap.Api.AspNet3.Models;
using Newtonsoft.Json;

namespace Fiap.Api.AspNet3.Clients
{
    public class CursoClient
    {
        private readonly string endpoint = "https://5cb544bd07f233001424ceb8.mockapi.io/fiap/curso";
        private readonly HttpClient httpClient;

        public CursoClient()
        {
            httpClient = new HttpClient();
        }

        public async Task<IList<CursoModel>> Get()
        {
            var resposta = await httpClient.GetAsync(endpoint);

            if (resposta.IsSuccessStatusCode)
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<List<CursoModel>>(conteudoJson);
                return cursos;
            }
            else
            {
                throw new Exception("Não foi possível consultar os cursos");
            }           
        }

        public async Task<CursoModel> Get(int id)
        {
            var resposta = await httpClient.GetAsync($"{endpoint}/{id}");

            if (resposta.IsSuccessStatusCode)
            {
                var conteudoJson = await resposta.Content.ReadAsStringAsync();
                var cursos = JsonConvert.DeserializeObject<CursoModel>(conteudoJson);
                return cursos;
            }
            else
            {
                throw new Exception("Não foi possível consultar o curso");
            }
        }

        public async Task Delete(int id)
        {
            var resposta = await httpClient.DeleteAsync($"{endpoint}/{id}");

            if (!resposta.IsSuccessStatusCode)
            {              
                throw new Exception("Não foi possível remover o curso");
            }
        }

        public async Task Update(CursoModel cursoModel)
        {
            var conteudJson = JsonConvert.SerializeObject(cursoModel);
            var conteudoJsonString = new StringContent(conteudJson, System.Text.Encoding.UTF8, "application/json");
            var resposta = await httpClient.PutAsync($"{endpoint}/{cursoModel.Id}", conteudoJsonString);

            if (!resposta.IsSuccessStatusCode)
            {
                throw new Exception("Não foi possível atualizar o curso");
            }
        }

        public async Task<int> Insert(CursoModel cursoModel)
        {
            var conteudJson = JsonConvert.SerializeObject(cursoModel);
            var conteudoJsonString = new StringContent(conteudJson, System.Text.Encoding.UTF8, "application/json");
            var resposta = await httpClient.PostAsync(endpoint, conteudoJsonString);

            if (!resposta.IsSuccessStatusCode)
            {
                throw new Exception("Não foi possível incluir o curso");
            }
            else
            {
                var conteudoResposta = await resposta.Content.ReadAsStringAsync();
                var cursoModelRetorno = JsonConvert.DeserializeObject<CursoModel>(conteudoResposta);
                return cursoModelRetorno.Id;
            }
        }

    }
}
//criar o controller do curso e usar os métodos do CursoClient