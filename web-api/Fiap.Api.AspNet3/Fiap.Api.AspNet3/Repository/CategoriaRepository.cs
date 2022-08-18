using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Repository
{
    public class CategoriaRepository : ICategoriaRepository
    {
        public DataContext Ctx { get; set; }

        public CategoriaRepository(DataContext context)
        {
            Ctx = context;
        }

        public void Delete(CategoriaModel categoriaModel)
        {
            Ctx.Categorias.Remove(categoriaModel);
            Ctx.SaveChanges();
        }

        public CategoriaModel Get(int id)
        {
            var categoria = Ctx.Categorias.Find(id);
            return categoria;
        }

        public IList<CategoriaModel> GetAll()
        {
            var listaCategoria = Ctx.Categorias.AsNoTracking().ToList();
            return listaCategoria;
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
    }
}
