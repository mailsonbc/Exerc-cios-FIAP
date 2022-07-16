using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class ClienteRepository
    {
        private readonly DataContext dataContext;
        public ClienteRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public List<ClienteModel> FindAll()
        {
            return dataContext.Clientes.ToList<ClienteModel>();
        }

        public ClienteModel FindById(int clienteId)
        {
            return dataContext.Clientes.Find(clienteId);
        }

        public List<ClienteModel> FindByName(string nomeCliente)
        {
            return null;
        }

        public void Insert(ClienteModel clienteModel)
        {
            dataContext.Clientes.Add(clienteModel);
            dataContext.SaveChanges();
        }

        public void UpDate(ClienteModel clienteModel)
        {
            dataContext.Clientes.Update(clienteModel);
            dataContext.SaveChanges();
        }

        public void Delete(int idCliente)
        {
            var cliente = FindById(idCliente);
            Delete(cliente);
        }
        public void Delete(ClienteModel clienteModel)
        {
            dataContext.Clientes.Remove(clienteModel);
            dataContext.SaveChanges();
        }
    }
}
