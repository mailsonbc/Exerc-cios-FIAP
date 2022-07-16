using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository clienteRepository;

        public ClienteController(DataContext context)
        {
            clienteRepository = new ClienteRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaClientes = clienteRepository.FindAll();

            return View(listaClientes);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                clienteRepository.Insert(clienteModel);
                return RedirectToAction("Index");
            }
            else
            {                
                return View();
            }
            
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var clienteModel = clienteRepository.FindById(id);
            if(clienteModel == null)
            {
                return NotFound();
            }
            return View(clienteModel);
        }

        [HttpPost]
        public IActionResult Editar(ClienteModel clienteModel)
        {
            if (ModelState.IsValid)
            {
                clienteRepository.UpDate(clienteModel);
                return RedirectToAction("Index");
            }
            return View(clienteModel);
        }

        [HttpGet]
        public IActionResult Detalhe(int id)
        {
            var clienteModel = clienteRepository.FindById(id);
            if(clienteModel == null)
            {
                return NotFound();
            }
            return View(clienteModel);
        }

        [HttpPost]
        public IActionResult Help()
        {
            return View();
        }
    }
}
