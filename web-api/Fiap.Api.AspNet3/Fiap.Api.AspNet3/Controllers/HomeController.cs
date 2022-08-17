using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Olá mundo - Get";
        }

        [HttpPost]
        public string Post()
        {
            return "Olá mundo - Post";
        }

        [HttpPut]
        public string Put()
        {
            return "Olá mundo - Put";
        }

        [HttpDelete]
        public string Delete()
        {
            return "Olá mundo - Delete";
        }
    }
}
