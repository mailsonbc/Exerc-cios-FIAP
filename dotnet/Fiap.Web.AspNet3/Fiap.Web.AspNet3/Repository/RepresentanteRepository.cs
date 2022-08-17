using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Repository
{
    public class RepresentanteRepository : IRepresentanteRepository
    {
        private readonly DataContext dataContext;
        public RepresentanteRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public List<RepresentanteModel> FindAll()
        {
            return dataContext.Representantes.ToList<RepresentanteModel>();
        }

        public RepresentanteModel? FindByIdWithClientes(int idRepresentante)
        {
            return dataContext.Representantes.Include(r => r.Clientes).SingleOrDefault(r => r.RepresentanteId == idRepresentante);
        }

        public RepresentanteModel? FindById(int representanteId)
        {
            return dataContext.Representantes.Find(representanteId);
        }

        public List<RepresentanteModel> FindByName(string nomeRepresentante)
        {
            return null;
        }

        public void Insert(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Add(representanteModel);
            dataContext.SaveChanges();
        }

        public void UpDate(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Update(representanteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int idRepresentante)
        {
            var representante = FindById(idRepresentante);
            Delete(representante);
        }
        public void Delete(RepresentanteModel representanteModel)
        {
            dataContext.Representantes.Remove(representanteModel);
            dataContext.SaveChanges();
        }

    }
}
