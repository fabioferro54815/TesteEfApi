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
            using (TesteEFContext ctx = new TesteEFContext())
            {
                return ctx.Usuarios.ToList();
            }
        }

        public Usuarios ListarPorId(int id)
        {
            using (TesteEFContext ctx = new TesteEFContext())
            {
                return ctx.Usuarios.Find(id);
            }
        }
    }
}
