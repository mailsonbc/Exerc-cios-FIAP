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

        public void Delete(int id)
        {
            //Ctx.Marcas.Remove(id);
            Ctx.SaveChanges();
        }

        public MarcaModel Get(int id)
        {
            var marca = Ctx.Marcas.Find(id);
            return marca;
        }

        public IList<MarcaModel> GetAll()
        {
            var listaMarcas = Ctx.Marcas.AsNoTracking().ToList();
            return listaMarcas;
        }

        public void Post(MarcaModel marcaModel)
        {
            Ctx.Marcas.Add(marcaModel);
        }

        public void Put(MarcaModel marcaModel)
        {
            Ctx.Marcas.Update(marcaModel);
            Ctx.SaveChanges();
        }
    }
}
