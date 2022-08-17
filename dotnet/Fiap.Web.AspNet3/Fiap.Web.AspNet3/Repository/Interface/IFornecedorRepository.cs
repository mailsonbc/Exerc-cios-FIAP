using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository.Interface
{
    public interface IFornecedorRepository
    {
        public List<FornecedorModel> FindAll();

        public FornecedorModel FindById(int idFornecedor);

        public void Insert(FornecedorModel fornecedorModel);

        public void UpDate(FornecedorModel fornecedorModel);
        public void Delete(int id);

        public void Delete(FornecedorModel fornecedorModel);
    }
}
