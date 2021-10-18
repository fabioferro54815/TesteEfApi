using System;
using System.Collections.Generic;

#nullable disable

namespace Teste.Performace.EF.Domains
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
