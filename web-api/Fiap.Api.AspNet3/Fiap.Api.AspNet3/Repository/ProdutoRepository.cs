using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext Ctx;

        public ProdutoRepository(DataContext dataContext)
        {
            Ctx = dataContext;
        }

        public IList<ProdutoModel> GetAll()
        {
            var produto = Ctx.Produtos.AsNoTracking().ToList<ProdutoModel>();
            return produto;
        }

        public ProdutoModel Get(int id)
        {
            var produto = Ctx.Produtos.Find(id);
            return produto;
        }

        public void Post(ProdutoModel produtoModel)
        {
            Ctx.Produtos.Add(produtoModel);
            Ctx.SaveChanges();
        }

        public void Put(ProdutoModel produtoModel)
        {
            Ctx.Produtos.Update(produtoModel);
            Ctx.SaveChanges();
        }

        public void Delete(ProdutoModel produtoModel)
        {
            Ctx.Produtos.Remove(produtoModel);
            Ctx.SaveChanges();
        }
    }
}
