using Fiap.Api.AspNet3.Models;

namespace Fiap.Api.AspNet3.Repository.Interface
{
    public interface ICategoriaRepository
    {
        public IList<CategoriaModel> GetAll();
        public CategoriaModel Get(int id);
        public void Post(CategoriaModel categoriaModel);
        public void Put(CategoriaModel categoriaModel);
        public void Delete(CategoriaModel categoriaModel);
    }
}
