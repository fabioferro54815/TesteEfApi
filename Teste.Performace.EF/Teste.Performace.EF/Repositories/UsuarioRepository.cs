using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Performace.EF.Contexts;
using Teste.Performace.EF.Domains;
using Teste.Performace.EF.Interfaces;

namespace Teste.Performace.EF.Repositories
{
    public class UsuarioRepository : IUsuarios
    {
        public List<Usuarios> Listar()
        {
            using TesteEFContext ctx = new TesteEFContext();

            return ctx.Usuarios.ToList();
        }

        public Usuarios ListarPorId(int id)
        {
            using TesteEFContext ctx = new TesteEFContext();

            return ctx.Usuarios.Find(id);
        }

        public void Cadastrar(Usuarios usuario)
        {
            using TesteEFContext ctx = new TesteEFContext();

            ctx.Add(usuario);
            ctx.SaveChanges();
        }

        public void Alterar(Usuarios usuario)
        {
            using TesteEFContext ctx = new TesteEFContext();

            Usuarios usuarioBuscado = ctx.Usuarios.FirstOrDefault(x => x.Id == usuario.Id);

            usuarioBuscado.Nome = usuario.Nome;
            usuarioBuscado.Email = usuario.Email;

            ctx.Update(usuarioBuscado);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            using TesteEFContext ctx = new TesteEFContext();

            Usuarios usuarioBuscado = ctx.Usuarios.Find(id);
            ctx.Usuarios.Remove(usuarioBuscado);
            ctx.SaveChanges();
        }
    }
}
