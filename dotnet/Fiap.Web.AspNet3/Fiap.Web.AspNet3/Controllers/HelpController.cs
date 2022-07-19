using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class HelpController : Controller
    {
        private DataContext _dataContext;
        public HelpController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            //var fornecedor = new FornecedorModel();
            //fornecedor.ForncedorNome = "Teste";
            //fornecedor.Cnpj = "15249630000123";
            //fornecedor.Email = "email@email.com";
            //fornecedor.Telefone = "1199990000";

            
            //_dataContext.Fornecedores.Add(fornecedor);
            //_dataContext.SaveChanges();
            return View();
        }

        public IActionResult About()
        {
            return View("AboutUs");
        }

        public IActionResult Content()
        {
            //return Content("Retornando o conteúdo em formato string");

            return RedirectToAction("Index", "Home");
        }
    }
}
