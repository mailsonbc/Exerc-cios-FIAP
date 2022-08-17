using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcaController : ControllerBase
    {
        private readonly DataContext dataContext;
        public MarcaController(DataContext ctx)
        {
            dataContext = ctx;
        }

        [HttpGet]
        public IList<MarcaModel> Get()
        {
            var listaMarcas = dataContext.Marcas.AsNoTracking().ToList<MarcaModel>();
            return listaMarcas;
        }

        [HttpGet("{id}")]
        public MarcaModel Get(int id)
        {
            var marca = dataContext.Marcas.Find(id);
            return marca;
        }
    }
}
//gerar os repositórios