using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JPennacchi.WebApi.Controllers
{
    [ApiController]
    [Route("home")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [Route("anonimo")]
        [AllowAnonymous]
        public string Anonimos() => "anonimos";

        [HttpGet]
        [Route("autorizado")]
        [Authorize]
        public string Autorizados() => "autorizados";

        [HttpGet]
        [Route("gerente")]
        [Authorize(Roles = "gerente")]
        public string Gerentes() => "gerentes";

        [HttpGet]
        [Route("funcionario")]
        [Authorize(Roles = "funcionario")]
        public string Funcionarios() => "funcionarios";

    }
}
