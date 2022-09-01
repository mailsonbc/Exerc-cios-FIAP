using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Repository
{
    public class MarcaRepository : IMarcaRepository
    {
        private readonly DataContext Ctx;

        public MarcaRepository(DataContext _dataContext)
        {
            Ctx = _dataContext;
        }

        public IList<MarcaModel> GetAll()
        {
            var marcaModel = Ctx.Marcas.AsNoTracking().ToList<MarcaModel>();
            return marcaModel;
        }

        public int Count()
        {
            return Ctx.Marcas.Count();
        }

        public IList<MarcaModel> GetAll(int pagina, int tamanho)
        {
            IList<MarcaModel> listaMarcas = Ctx.Marcas.Skip(tamanho * pagina).Take(tamanho).ToList();
            return listaMarcas;
        }

        public MarcaModel Get(int id)
        {
            var marcaModel = Ctx.Marcas.Find(id);
            return marcaModel;
        }

        public void Post(MarcaModel marcaModel)
        {
            Ctx.Marcas.Add(marcaModel);
            Ctx.SaveChanges();
        }

        public void Put(MarcaModel marcaModel)
        {
            Ctx.Marcas.Update(marcaModel);
            Ctx.SaveChanges();
        }

        public void Delete(MarcaModel marcaModel)
        {
            Ctx.Marcas.Remove(marcaModel);
            Ctx.SaveChanges();
        }
    }
}
