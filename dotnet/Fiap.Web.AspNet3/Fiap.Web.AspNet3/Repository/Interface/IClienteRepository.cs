using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository.Interface
{
    public interface IClienteRepository
    {
        public IList<ClienteModel> FindAll();

        public IList<ClienteModel> FindAllOrderByNomeAsc();

        public IList<ClienteModel> FindAllOrderByNomeDesc();

        public ClienteModel FindById(int clienteId);

        public IList<ClienteModel> FindByNome(string nomeCliente);

        public IList<ClienteModel> FindByNomeAndEmail(string nomeCliente, string email);

        public IList<ClienteModel> FindByNomeAndEmailAndRepresentante(string nomeCliente, string email, int idRepresentante);

        public void Insert(ClienteModel clienteModel);

        public void UpDate(ClienteModel clienteModel);

        public void Delete(int idCliente);
        public void Delete(ClienteModel clienteModel);
    }
}
