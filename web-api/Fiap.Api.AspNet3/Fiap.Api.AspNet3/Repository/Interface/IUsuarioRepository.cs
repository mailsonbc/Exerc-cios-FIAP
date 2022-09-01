using Fiap.Api.AspNet3.Models;

namespace Fiap.Api.AspNet3.Repository.Interface
{
    public interface IUsuarioRepository
    {
        public IList<UsuarioModel> GetAll();
        public UsuarioModel Get(int id);
        public void Post(UsuarioModel usuarioModel);
        public void Put(UsuarioModel usuarioModel);
        public void Delete(UsuarioModel usuarioModel);
    }
}
