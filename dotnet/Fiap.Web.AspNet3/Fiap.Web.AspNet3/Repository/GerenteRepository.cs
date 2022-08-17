using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository.Interface;

namespace Fiap.Web.AspNet3.Repository
{
    public class GerenteRepository : IGerenteRepository
    {
        private readonly DataContext dataContext;
        public GerenteRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public List<GerenteModel> FindAll()
        {
            return dataContext.Gerentes.ToList<GerenteModel>();
        }

        public GerenteModel FindById(int gerenteId)
        {
            return dataContext.Gerentes.Find(gerenteId);
        }

        public List<GerenteModel> FinfByName(string nomeGerente)
        {
            return null;
        }

        public void Insert(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Add(gerenteModel);
            dataContext.SaveChanges();
        }

        public void Update(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Update(gerenteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int idGerente)
        {
            var gerente = FindById(idGerente);
            Delete(gerente);
        }

        public void Delete(GerenteModel gerenteModel)
        {
            dataContext.Gerentes.Remove(gerenteModel);
            dataContext.SaveChanges();
        }
    }
}
