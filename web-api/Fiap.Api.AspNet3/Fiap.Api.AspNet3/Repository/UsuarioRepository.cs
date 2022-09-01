using Fiap.Api.AspNet3.Data;
using Fiap.Api.AspNet3.Models;
using Fiap.Api.AspNet3.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.AspNet3.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly DataContext Ctx;

        public UsuarioRepository(DataContext ctx)
        {
            Ctx = ctx;
        }

        public IList<UsuarioModel> GetAll()
        {
            var usuario = Ctx.Usuarios.AsNoTracking().ToList<UsuarioModel>();
            return usuario;
        }

        public UsuarioModel Get(int id)
        {
            var usuario = Ctx.Usuarios.Find(id);
            return usuario;
        }

        public void Post(UsuarioModel usuarioModel)
        {
            Ctx.Usuarios.Add(usuarioModel);
            Ctx.SaveChanges();
        }

        public void Put(UsuarioModel usuarioModel)
        {
            Ctx.Usuarios.Update(usuarioModel);
            Ctx.SaveChanges();
        }

        public void Delete(UsuarioModel usuarioModel)
        {
            Ctx.Usuarios.Remove(usuarioModel);
            Ctx.SaveChanges();
        }
    }
}
