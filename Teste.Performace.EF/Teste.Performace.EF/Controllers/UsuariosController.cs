using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste.Performace.EF.Domains;
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

        [HttpGet("{id}")]
        public IActionResult ListarPorId(int id)
        {
            return Ok(UsuarioRepository.ListarPorId(id));
        }

        [HttpPost]
        public IActionResult Cadastrar(Usuarios usuario)
        {
            UsuarioRepository.Cadastrar(usuario);
            return Ok();
        }

        [HttpPut]
        public IActionResult Alterar(Usuarios usuario)
        {
            Usuarios usuarioBuscado = UsuarioRepository.ListarPorId(usuario.Id);

            if (usuarioBuscado == null)
                return NotFound();

            UsuarioRepository.Alterar(usuario);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
        {
            UsuarioRepository.Deletar(id);
            return Ok();
        }
    }
}