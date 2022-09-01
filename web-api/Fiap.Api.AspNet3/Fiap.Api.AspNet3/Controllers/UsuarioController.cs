using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Fiap.Api.AspNet3.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Senior")]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository usuarioRepository;

        public UsuarioController(IUsuarioRepository _usuarioRepository)
        {
            usuarioRepository = _usuarioRepository;
        }

        [HttpGet]
        public IList<UsuarioModel> Get()
        {
            var usuario = usuarioRepository.GetAll();
            return usuario;
        }

        [HttpGet("{id}")]
        public UsuarioModel Get(int id)
        {
            var usuario = usuarioRepository.Get(id);
            return usuario;
        }

        [HttpPost]
        public void Post(UsuarioModel usuarioModel)
        {
            usuarioRepository.Post(usuarioModel);
        }

        [HttpPut]
        public void Put(UsuarioModel usuarioModel)
        {
            usuarioRepository.Put(usuarioModel);
        }

        [HttpDelete]
        public void Delete(UsuarioModel usuarioModel)
        {
            usuarioRepository.Delete(usuarioModel);
        }

        [HttpPost]
        [Route("Login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login([FromBody] UsuarioModel usuarioModel)
        {
            if (usuarioModel.Senha.Equals("123456"))
            {
                usuarioModel.NomeUsuario = "Flávio";
                usuarioModel.Regra = "Senior";

                var tokenUsuario = AuthenticationService.GetToken(usuarioModel);

                return new
                {
                    usurio = usuarioModel,
                    token = tokenUsuario
                };
            }
            else
            {
                return NotFound();
            }            
        }
    }
}
