using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Fiap.Api.AspNet3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaRepository categoriaRepository;

        public CategoriaController(ICategoriaRepository _categoriaRepository)
        {
            categoriaRepository = _categoriaRepository;
        }

        [HttpGet]
        public IList<CategoriaModel> Get()
        {
            var cat = categoriaRepository.GetAll();
            return cat;
        }

        [HttpGet("{id}")]
        public CategoriaModel Get(int id)
        {
            var cat = categoriaRepository.Get(id);
            return cat;
        }

        [HttpPost]
        public void Post(CategoriaModel categoriaModel)
        {
            categoriaRepository.Post(categoriaModel);
        }

        [HttpPut]
        public void Put(CategoriaModel categoriaModel)
        {
            categoriaRepository.Put(categoriaModel);
        }

        [HttpDelete]
        public void Delete(CategoriaModel categoriaModel)
        {
            categoriaRepository.Delete(categoriaModel);
        }
    }
}
