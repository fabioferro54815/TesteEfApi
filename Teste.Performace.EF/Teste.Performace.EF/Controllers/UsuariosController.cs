using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Performace.EF.Interfaces;
using Teste.Performace.EF.Repositories;

namespace Teste.Performace.EF.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private IUsuarios UsuarioRepository { get; set; }

        public UsuariosController()
        {
            UsuarioRepository = new UsuarioRepository();
        }

        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(UsuarioRepository.Listar());
        }
    }
}