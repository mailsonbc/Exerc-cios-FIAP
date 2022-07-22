using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Microsoft.EntityFrameworkCore;

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
            return dataContext.Clientes.Include(c => c.Representante).ToList<ClienteModel>();
        }

        public ClienteModel FindById(int clienteId)
        {
            var cliente =
                dataContext.Clientes //SELECT campos
                .Include(c => c.Representante) //Inner Join é possível por mais includes .Include(c => c.Gerente)
                .SingleOrDefault(c => c.ClienteId == clienteId); //Where
            return cliente;
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
