using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository.Interface
{
    public interface IRepresentanteRepository
    {
        public List<RepresentanteModel> FindAll();

        public RepresentanteModel? FindByIdWithClientes(int idRepresentante);

        public RepresentanteModel? FindById(int representanteId);

        public List<RepresentanteModel> FindByName(string nomeRepresentante);

        public void Insert(RepresentanteModel representanteModel);

        public void UpDate(RepresentanteModel representanteModel);

        public void Delete(int idRepresentante);
        public void Delete(RepresentanteModel representanteModel);

    }

}
