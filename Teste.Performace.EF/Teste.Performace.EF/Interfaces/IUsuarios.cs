using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Performace.EF.Domains;

namespace Teste.Performace.EF.Interfaces
{
    public interface IUsuarios
    {
        List<Usuarios> Listar();

        Usuarios ListarPorId(int id);
    }
}
