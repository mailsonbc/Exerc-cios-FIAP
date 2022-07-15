﻿using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Controllers
{
    public class RepresentanteController : Controller
    {
        //private readonly DataContext _context;
        private readonly RepresentanteRepository representanteRepository;

        public RepresentanteController(DataContext context)
        {
            //_context = context;
            representanteRepository = new RepresentanteRepository(context);
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listaRepresentantes = representanteRepository.FindAll();

            return View(listaRepresentantes);           //ToList para listar tudo
                          
        }

        [HttpGet]
        public IActionResult Details(int id)
        {

            var representanteModel = representanteRepository.FindById(id);
                //.FirstOrDefaultAsync(m => m.RepresentanteId == id);     //FirstOrDefault ou Find(id) para lista apenas um item
            if (representanteModel == null)
            {
                return NotFound();
            }

            return View(representanteModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("RepresentanteId,NomeRepresentante")] RepresentanteModel representanteModel)
        {
            if (ModelState.IsValid)
            {
                representanteRepository.Insert(representanteModel);
                return RedirectToAction(nameof(Index));
            }
            return View(representanteModel);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {


            var representanteModel = representanteRepository.FindById(id);
            if (representanteModel == null)
            {
                return NotFound();
            }
            return View(representanteModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("RepresentanteId,NomeRepresentante")] RepresentanteModel representanteModel)
        {
            if (id != representanteModel.RepresentanteId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                representanteRepository.UpDate(representanteModel);
                //try
                //{
                //    representanteRepository.UpDate(representanteModel);                    
                //}
                //catch (DbUpdateConcurrencyException)
                //{
                //    if (!RepresentanteModelExists(representanteModel.RepresentanteId))
                //    {
                //        return NotFound();
                //    }
                //    else
                //    {
                //        throw;
                //    }
                //}
                //return RedirectToAction(nameof(Index));
            }
            return View(representanteModel);
        }

        //[HttpGet]
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null || _context.Representantes == null)
        //    {
        //        return NotFound();
        //    }

        //    var representanteModel = await _context.Representantes
        //        .FirstOrDefaultAsync(m => m.RepresentanteId == id);
        //    if (representanteModel == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(representanteModel);
        //}


        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    if (_context.Representantes == null)
        //    {
        //        return Problem("Entity set 'DataContext.Representantes'  is null.");
        //    }
        //    var representanteModel = await _context.Representantes.FindAsync(id);
        //    if (representanteModel != null)
        //    {
        //        _context.Representantes.Remove(representanteModel);
        //    }

        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool RepresentanteModelExists(int id)
        //{
        //  return (_context.Representantes?.Any(e => e.RepresentanteId == id)).GetValueOrDefault();
        //}
    }
}
