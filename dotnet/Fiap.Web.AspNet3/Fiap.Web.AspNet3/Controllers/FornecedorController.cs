﻿using Fiap.Web.AspNet3.Controllers.Filters;
using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Web.AspNet3.Controllers
{
    [FiapAuthFilter]
    public class FornecedorController : Controller
    {
        private readonly FornecedorRepository fornecedorRepository;

        public FornecedorController(DataContext context)
        {
            fornecedorRepository = new FornecedorRepository(context);
        }

        public IActionResult Index()
        {
            var fornecedores = fornecedorRepository.FindAll();

            return View(fornecedores);
        }

        public IActionResult Details(int id)
        {            
            var fornecedorModel = fornecedorRepository.FindById(id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("FornecedorId,ForncedorNome,Cnpj,Telefone,Email")] FornecedorModel fornecedorModel)
        {
            if (ModelState.IsValid)
            {
                fornecedorRepository.Insert(fornecedorModel);
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorModel);
        }

        public IActionResult Edit(int id)
        {
            var fornecedorModel = fornecedorRepository.FindById(id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }
            return View(fornecedorModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("FornecedorId,ForncedorNome,Cnpj,Telefone,Email")] FornecedorModel fornecedorModel)
        {
            if (id != fornecedorModel.FornecedorId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    fornecedorRepository.UpDate(fornecedorModel);
                }
                catch (DbUpdateConcurrencyException)
                {                    
                    throw;                    
                }
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedorModel);
        }

        public IActionResult Delete(int id)
        {
           var fornecedorModel = fornecedorRepository.FindById(id);
            if (fornecedorModel == null)
            {
                return NotFound();
            }

            return View(fornecedorModel);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            fornecedorRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
