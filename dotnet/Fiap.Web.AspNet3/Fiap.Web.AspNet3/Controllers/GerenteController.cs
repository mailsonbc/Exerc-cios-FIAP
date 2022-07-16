using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Web.AspNet3.Controllers
{
    public class GerenteController : Controller
    {
        private readonly GerenteRepository gerenteRepository;

        public GerenteController(DataContext context)
        {
            gerenteRepository = new GerenteRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaGerentes = gerenteRepository.FindAll();

            return View(listaGerentes);
        }

        [HttpGet]
        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(GerenteModel gerenteModel)
        {
            if (ModelState.IsValid)
            {
                gerenteRepository.Insert(gerenteModel);
                return RedirectToAction("Index");
            }
            
            return View(gerenteModel);
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {
            var gerenteModel = gerenteRepository.FindById(id);
            if(gerenteModel == null)
            {
                return NotFound();
            }
            return View(gerenteModel);
        }

        [HttpPost]
        public IActionResult Editar(GerenteModel gerenteModel)
        {
            if (ModelState.IsValid)
            {
                gerenteRepository.Update(gerenteModel);
                return RedirectToAction("Index");
            }
            return View(gerenteModel);
        }

        [HttpGet]
        public IActionResult Detalhe(int id)
        {
            var gerenteModel = gerenteRepository.FindById(id);
            if (gerenteModel == null)
            {
                return NotFound();
            }
            return View(gerenteModel);
        }
    }
}
