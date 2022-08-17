using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Repository
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly DataContext dataContext;
        public ClienteRepository(DataContext ctx)
        {
            dataContext = ctx;
        }

        public IList<ClienteModel> FindAll()
        {
            return dataContext.Clientes.Include(c => c.Representante).ToList<ClienteModel>();
        }

        public IList<ClienteModel> FindAllOrderByNomeAsc()
        {
            //var listaClientes = dataContext.Clientes.Include(c => c.Representante).ToList();
            var listaClientes = dataContext.Clientes.Include(c => c.Representante).OrderBy(c => c.Nome).ToList();
            return listaClientes == null ? new List<ClienteModel>() : listaClientes;
        }

        public IList<ClienteModel> FindAllOrderByNomeDesc()
        {
            //var listaClientes = dataContext.Clientes.Include(c => c.Representante).ToList();
            var listaClientes = dataContext.Clientes.Include(c => c.Representante).OrderByDescending(c => c.Nome).ToList();
            return listaClientes == null ? new List<ClienteModel>() : listaClientes;
        }

        public ClienteModel FindById(int clienteId)
        {
            var cliente =
                dataContext.Clientes //SELECT campos
                .Include(c => c.Representante) //Inner Join é possível por mais includes .Include(c => c.Gerente)
                .SingleOrDefault(c => c.ClienteId == clienteId); //Where
            return cliente;
        }

        public IList<ClienteModel> FindByNome(string nomeCliente)
        {
            var listaClientes = dataContext.Clientes.Include(c => c.Representante).Where(c => c.Nome.Contains(nomeCliente)).OrderBy(c => c.Nome).ToList();
            return listaClientes == null ? new List<ClienteModel>() : listaClientes;
        }

        public IList<ClienteModel> FindByNomeAndEmail(string nomeCliente, string email)
        {
            var listaClientes = dataContext.Clientes.Include(c => c.Representante)
                .Where(c => c.Nome.Contains(nomeCliente) && c.Email.Contains(email)).OrderBy(c => c.Nome).ToList();
            return listaClientes == null ? new List<ClienteModel>() : listaClientes;
        }

        public IList<ClienteModel> FindByNomeAndEmailAndRepresentante(string nomeCliente, string email, int idRepresentante)
        {
            var listaClientes = dataContext.Clientes.Include(c => c.Representante)
                .Where(c => c.Nome.Contains(nomeCliente) && c.Email.Contains(email) && (0 == idRepresentante || (c.RepresentanteId == idRepresentante)))
                .OrderBy(c => c.Nome).ToList();
            return listaClientes == null ? new List<ClienteModel>() : listaClientes;
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
