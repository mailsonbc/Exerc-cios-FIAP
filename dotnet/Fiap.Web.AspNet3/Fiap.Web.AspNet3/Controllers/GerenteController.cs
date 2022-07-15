﻿using Fiap.Web.AspNet3.Data;
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
            var listaGerente = gerenteRepository.FindAll();

            return View(listaGerente);
        }
    }
}