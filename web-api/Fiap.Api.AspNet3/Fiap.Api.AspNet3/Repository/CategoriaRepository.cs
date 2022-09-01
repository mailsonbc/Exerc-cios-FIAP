using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Web.Http;
using System.Web.Http.Description;

namespace Fiap.Api.AspNet3.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly DataContext Ctx;

        public CategoriaRepository(DataContext context)
        {
            Ctx = context;
        }

        public IList<CategoriaModel> GetAll()
        {
            var listaCategoria = Ctx.Categorias.AsNoTracking().ToList<CategoriaModel>();
            return listaCategoria;
        }

        public CategoriaModel Get(int id)
        {
            var categoria = Ctx.Categorias.Find(id);
            return categoria;
        }

        public void Post(CategoriaModel categoriaModel)
        {
            Ctx.Categorias.Add(categoriaModel);
            Ctx.SaveChanges();
        }

        public void Put(CategoriaModel categoriaModel)
        {
            Ctx.Categorias.Update(categoriaModel);
            Ctx.SaveChanges();
        }

        public void Delete(CategoriaModel categoriaModel)
        {
            Ctx.Categorias.Remove(categoriaModel);
            Ctx.SaveChanges();
        }
    }
}
