using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class RepresentanteRepository
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

        public RepresentanteModel FindById(int representanteId)
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
