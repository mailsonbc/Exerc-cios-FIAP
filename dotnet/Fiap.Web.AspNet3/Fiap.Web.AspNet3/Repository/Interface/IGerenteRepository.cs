using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository.Interface
{
    public interface IGerenteRepository
    {
        public List<GerenteModel> FindAll();

        public GerenteModel FindById(int gerenteId);

        public List<GerenteModel> FinfByName(string nomeGerente);

        public void Insert(GerenteModel gerenteModel);

        public void Update(GerenteModel gerenteModel);

        public void Delete(int idGerente);

        public void Delete(GerenteModel gerenteModel);
    }
}
