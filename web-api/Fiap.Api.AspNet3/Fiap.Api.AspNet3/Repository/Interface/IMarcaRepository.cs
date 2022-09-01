using Fiap.Api.AspNet3.Models;

namespace Fiap.Api.AspNet3.Repository.Interface
{
    public interface IMarcaRepository
    {
        public IList<MarcaModel> GetAll();
        public IList<MarcaModel> GetAll(int pagina, int tamanho);
        public int Count();
        public MarcaModel Get(int id);        
        public void Post(MarcaModel marcaModel);
        public void Put(MarcaModel marcaModel);
        public void Delete(MarcaModel marcaModel);
    }
}
