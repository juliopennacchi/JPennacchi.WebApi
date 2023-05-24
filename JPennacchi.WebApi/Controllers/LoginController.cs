using JPennacchi.Application.Auth;
using JPennacchi.Application.RequestResponse.Login;
using JPennacchi.Application.Services.Interfaces;
using JPennacchi.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JPennacchi.WebApi.Controllers
{
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public LoginController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;   
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<LoginResponse>> AuthenticateAsync([FromBody] LoginRequest request)
        {
            //Obtem Usuario
            var usuario = await _usuarioService.GetAsync(request.Nome, request.Senha);

            if(usuario == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            //Gerar Token
            var token = TokenService.GenerateToken(usuario);

            //Oculta Senha para retorno
            usuario.Senha = string.Empty;

            //Retonar os dados
            return new LoginResponse
            {
                Autenticado= true,
                Usuario = usuario,
                Token = token,
            };
        }
    }
}
