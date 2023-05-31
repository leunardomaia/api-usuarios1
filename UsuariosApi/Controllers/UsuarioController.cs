using Microsoft.AspNetCore.Mvc;
using UsuariosApi.Data.Dtos;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService cadastroService)
        {
            _usuarioService = cadastroService;
        }

        [HttpPost("cadastro")]
        public async Task<IActionResult> CadastrarUsuario( [FromBody] CreateUsuarioDto dto)
        {
            await _usuarioService.Cadastra(dto);
            return Ok("Usuário Cadastrado!");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login( [FromBody] LoginUsuarioDto dto)
        {
            var token = await _usuarioService.Login(dto);
            return Ok(token);
        }
    }
}