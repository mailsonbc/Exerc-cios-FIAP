using Fiap.Api.AspNet3.Models;

namespace Fiap.Api.AspNet3.Repository.Interface
{
    public interface IProdutoRepository
    {
        public IList<ProdutoModel> GetAll();
        public ProdutoModel Get(int id);
        public void Post(ProdutoModel produtoModel);
        public void Put(ProdutoModel produtoModel);
        public void Delete(ProdutoModel produtoModel);
    }
}
