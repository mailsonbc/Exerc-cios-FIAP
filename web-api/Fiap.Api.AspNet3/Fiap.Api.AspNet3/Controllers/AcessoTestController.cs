using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AcessoTestController : ControllerBase
    {
        [Route("Anonimo")]
        [AllowAnonymous]
        [HttpGet]
        public string Anonimo()
        {
            return "Anonimo";
        }

        [Route("Autenticado")]
        [HttpPatch]
        public string Autenticado()
        {
            return "Autenticado";
        }

        [Route("Junior")]
        [Authorize(Roles = "Junior, Pleno, Senior")]
        [HttpPost]
        public string Junior()
        {
            return "Junior";
        }

        [Route("Pleno")]
        [Authorize(Roles = "Pleno, Senior")]
        [HttpPut]
        public string Pleno()
        {
            return "Pleno";
        }

        [Route("Senior")]
        [Authorize(Roles = "Senior")]
        [HttpDelete]
        public string Senior()
        {
            return "Senior";
        }
    }
}
