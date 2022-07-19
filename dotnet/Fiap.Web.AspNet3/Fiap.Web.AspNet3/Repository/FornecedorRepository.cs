using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;

namespace Fiap.Web.AspNet3.Repository
{
    public class FornecedorRepository
    {
        private readonly DataContext datacontext;

        public FornecedorRepository(DataContext context)
        {
            datacontext = context;
        }

        public List<FornecedorModel> FindAll()
        {
            return datacontext.Fornecedores.ToList();
        }

        public FornecedorModel FindById(int idFornecedor)
        {
            return datacontext.Fornecedores.Find(idFornecedor);
        }

        public void Insert(FornecedorModel fornecedorModel)
        {
            datacontext.Fornecedores.Add(fornecedorModel);
            datacontext.SaveChanges();
        }

        public void UpDate(FornecedorModel fornecedorModel)
        {
            datacontext.Fornecedores.Update(fornecedorModel);
            datacontext.SaveChanges();
        }
        public void Delete(int id)
        {
            var fornecedor = new FornecedorModel();
            fornecedor.FornecedorId = id;
            Delete(fornecedor);
        }

        public void Delete(FornecedorModel fornecedorModel)
        {
            datacontext.Fornecedores.Remove(fornecedorModel);
            datacontext.SaveChanges();
        }
    }
}
