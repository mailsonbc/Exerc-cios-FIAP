using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoRepository produtoRepository;

        public ProdutoController(IProdutoRepository _produtoRepository)
        {
            produtoRepository = _produtoRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IList<ProdutoModel>>> Get()
        {
            var produto = produtoRepository.GetAll();
            if(produto.Count() == 0)
            {
                return NoContent();
            }
            return Ok(produto);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoModel>> Get(int id)
        {            
            if(id == 0)
            {
                return BadRequest(new { mensagem = $"Não foi possível encontrar o produto com o id = {id}" });
            }
            var produto = produtoRepository.Get(id);
            if (produto == null)
            {
                return NotFound();
            }
            return produto;
        }

        [HttpPost]
        public async Task<ActionResult<ProdutoModel>> Post(ProdutoModel produtoModel)
        {
            produtoRepository.Post(produtoModel);
            var location = new Uri(Request.GetEncodedUrl() + produtoModel.ProdutoId);
            return Created(location, produtoModel);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<ProdutoModel>> Put([FromRoute] int id, [FromBody] ProdutoModel produtoModel)
        {
            if(id != produtoModel.ProdutoId || id == 0)
            {
                return BadRequest(new { mensagem = $"O id: {id} não corresponde ao id: {produtoModel.ProdutoId}" });
            }
            produtoRepository.Put(produtoModel);
            return NoContent();            
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<ProdutoModel>> Delete([FromRoute] int id)
        {
            var produto = produtoRepository.Get(id);
            if (produto == null)
            {
                return NotFound();
            }
            else
            {
                produtoRepository.Delete(produto);
                return NoContent();
            }            
        }
    }
}
