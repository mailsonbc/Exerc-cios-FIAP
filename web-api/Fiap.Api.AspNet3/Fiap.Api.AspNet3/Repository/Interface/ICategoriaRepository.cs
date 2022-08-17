using Fiap.Api.AspNet3.Models;

namespace Fiap.Api.AspNet3.Repository.Interface
{
    public interface ICategoriaRepository
    {
        public IList<MarcaModel> GetAll();
        public MarcaModel Get(int id);
        public void Post(MarcaModel marcaModel);
        public void Put(MarcaModel marcaModel);
        public void Delete(int id);
    }
}
