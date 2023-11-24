using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using PSF.Dados.Interface;
using PSF.Dominio.Entities;
using PSF.WebApp.Helpers;

namespace PSF.WebApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepositorio _authRepositorio;
        public AuthController(IAuthRepositorio authRepositorio)
        {
            _authRepositorio = authRepositorio;
        }

        [HttpPost]
        [Route("Cadastrar")]
        public async Task<ActionResult<Usuario>> Cadastrar(Usuario usuario)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados inválidos");
            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            var result = await _authRepositorio.Cadastrar(usuario);
            return Ok(result);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult<dynamic>> Login([FromBody] string usuario, string senha)
        {
            if (!ModelState.IsValid)
                return BadRequest("Dados inválidos");

            var user = _authRepositorio.BuscarUsuario(usuario);
            if (user == null)
            {
                return BadRequest("Usuário não encontrado");
            }

            if (!BCrypt.Net.BCrypt.Verify(user.Senha, senha))
            {
                return BadRequest("Credenciais Inválidas");
            }

            string token = TokenService.GenerateToken(user);

            return Ok(token);
        }

    }
}
