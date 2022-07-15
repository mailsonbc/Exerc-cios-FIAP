using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class GerenteRepository
    {
        private readonly DataContext dataContext;
        public GerenteRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public List<GerenteModel> FindAll()
        {
            return dataContext.Gerentes.ToList();
        }
    }
}
