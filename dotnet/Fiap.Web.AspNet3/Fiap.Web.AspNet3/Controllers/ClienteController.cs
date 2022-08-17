﻿using AutoMapper;
using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository;
using Fiap.Web.AspNet3.Repository.Interface;
using Fiap.Web.AspNet3.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Fiap.Web.AspNet3.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepository clienteRepository;
        private readonly IRepresentanteRepository representanteRepository;
        private readonly IMapper mapper;

        public ClienteController(IClienteRepository _clienteRepository, IRepresentanteRepository _representanteRepository, IMapper _mapper)
        {           
            clienteRepository = _clienteRepository;
            representanteRepository = _representanteRepository;
            mapper = _mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //var listaClientes = clienteRepository.FindAll();
            //var listaClientes = clienteRepository.FindAllOrderByNomeAsc();
            var vm = new ClientePesquisaViewModel();
            vm.Representantes = ComboRepresentantes();
            return View(vm);
        }

        //[HttpPost]
        //public IActionResult Pesquisar(ClientePesquisaViewModel clientePesquisaViewModel)
        //{
        //    //NomePesquisa = NomePesquisa == null ? string.Empty : NomePesquisa;
        //    //EmailPesquisa = EmailPesquisa == null ? string.Empty : EmailPesquisa;

        //    ViewBag.representantes = ComboRepresentantes();

        //    //var listaClientes = clienteRepository.FindByNomeAndEmailAndRepresentante(clientePesquisaViewModel.ClienteNome, clientePesquisaViewModel.ClienteEmail, clientePesquisaViewModel.RepresentanteId);

        //    return View("Index", clientePesquisaViewModel);
        //}

        [HttpPost]
        public IActionResult Pesquisar(ClientePesquisaViewModel clientePesquisaViewModel)
        {            
            var listaClientes = clienteRepository
                                    .FindByNomeAndEmailAndRepresentante(
                                        clientePesquisaViewModel.ClienteNome,
                                        clientePesquisaViewModel.ClienteEmail,
                                        clientePesquisaViewModel.RepresentanteId);
            var listaClienteVM = mapper.Map<IList<ClienteViewModel>>(listaClientes);
            clientePesquisaViewModel.Clientes = listaClienteVM;
            clientePesquisaViewModel.Representantes = ComboRepresentantes();
            return View("Index", clientePesquisaViewModel);            
        }

        [HttpGet]
        public IActionResult Novo()
        {            
            ViewBag.representantes = ComboRepresentantes();

            return View(new ClienteModel());
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
                ViewBag.representantes = ComboRepresentantes();

                return View(clienteModel);
            }
            
        }

        [HttpGet]
        public IActionResult Editar(int id)
        {            
            ViewBag.representantes = ComboRepresentantes();

            var clienteModel = clienteRepository.FindById(id);
            if (clienteModel == null)
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
            else
            {     
                ViewBag.representantes = ComboRepresentantes();
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

        private SelectList ComboRepresentantes()
        {
            var listaRepresentantes = representanteRepository.FindAll();
            var listaRepresentantesVM = mapper.Map<List<RepresentanteModel>>(listaRepresentantes);
            var selectListRepresentantes = new SelectList(listaRepresentantesVM, "RepresentanteId", "NomeRepresentante");
            return selectListRepresentantes;            
        }
    }
}
