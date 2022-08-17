using Fiap.Web.AspNet3.Data;
using Fiap.Web.AspNet3.Models;
using Fiap.Web.AspNet3.Repository.Interface;

namespace Fiap.Web.AspNet3.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext context;
        public UsuarioRepository(DataContext ctx)
        {
            context = ctx;
        }

        public UsuarioModel Login(UsuarioModel usuarioModel)
        {
            //var usuario = context.Usuarios.Where(u => u.UsuarioEmail == usuarioModel.UsuarioEmail && u.UsuarioSenha == usuarioModel.UsuarioSenha);
            //return (UsuarioModel)usuario;

            return new UsuarioModel()
            {
                UsuarioNome = "Admin",
                UsuarioId = 1
            };
        }
    }
}
