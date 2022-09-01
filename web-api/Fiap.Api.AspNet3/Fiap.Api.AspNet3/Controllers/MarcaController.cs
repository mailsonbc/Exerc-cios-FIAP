using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [Authorize]
    [ResponseCache(Duration = 30, VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any)]
    public class MarcaController : ControllerBase
    {
        private readonly IMarcaRepository marcaRepository;

        public MarcaController(IMarcaRepository _marcaRepository)
        {
            marcaRepository = _marcaRepository;
        }

        [HttpGet]
        [Authorize(Roles = "Junior, Pleno, Senior")]
        public async Task<ActionResult<IList<dynamic>>> GetMarcas([FromQuery] int pagina = 0, [FromQuery] int tamanho = 3)
        {
            var totalGeral = marcaRepository.Count();
            var totalPagina = (int)Math.Ceiling((double)totalGeral / tamanho);
            var anterior = pagina > 0 ? $"marca?pagina={pagina - 1}&tamanho={tamanho}" : "";
            var proxima = pagina < totalPagina - 1 ? $"marca?pagina={pagina + 1}&tamanho={tamanho}" : "";
            if (pagina > totalPagina)
            {
                return NotFound();
            }
            var marca = marcaRepository.GetAll(pagina, tamanho);
            if (marca.Count == 0)
            {
                return NoContent();
            }
            return Ok
                (
                    new
                    {
                        total = totalGeral,
                        totalPaginas = totalPagina,
                        anterior = anterior,
                        proxima = proxima,
                        marcas = marca
                    }
                );
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "Junior, Pleno, Senior")]
        [ResponseCache(Duration = 10, VaryByHeader = "User-Agent", Location = ResponseCacheLocation.Any)]
        public async Task<ActionResult<MarcaModel>> GetMarca(int id)
        {
            if(id == 0)
            {
                return BadRequest(new {mensagem = $"Não foi possível encontrar a marca com o id = {id}"});
            }
            var marca = marcaRepository.Get(id);
            if(marca == null)
            {
                return NotFound();
            }
            return marca;
        }

        [HttpPost]
        [Authorize(Roles = "Pleno, Senior")]
        public async Task<ActionResult<MarcaModel>> PostMarca([FromBody]MarcaModel marcaModel)
        {
            marcaRepository.Post(marcaModel);
            var location = new Uri(Request.GetEncodedUrl() + marcaModel.MarcaId);
            return Created(location, marcaModel);
        }

        [HttpPut("{id}")]
        [Authorize(Roles = "Pleno, Senior")]
        public async Task<ActionResult<MarcaModel>> PutMarca([FromRoute] int id, [FromBody]MarcaModel marcaModel)
        {
            if (id != marcaModel.MarcaId || id == 0)
            {
                return BadRequest(new { mensagem = $"O id: {id} não corresponde ao id: {marcaModel.MarcaId}" });
            }
            marcaRepository.Put(marcaModel);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Pleno, Senior")]
        public async Task<ActionResult<MarcaModel>> DeleteMarca([FromRoute]int id)
        {
            var marca = marcaRepository.Get(id);
            if(marca == null)
            {
                return NotFound();
            }
            else
            {
                marcaRepository.Delete(marca);
                return NoContent();
            }
        }
    }
}
