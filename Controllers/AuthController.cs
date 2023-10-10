using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace AuthenticationWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;

        // metodo para registrar um usuario

        // ActionResult + model para ser mostradon no swagger
        // hash é retornado para aprendizado apenas

        // atalho 'ctor' + tab cria um constructor rapidamente
        // injecao de dependencia

        public AuthController(IAuthService authService)
        {
            // underscore para destacar um membro privado de uma propriedade publica
            _authService = authService;
        }

        // decorator para rota post
        [HttpPost]
        public async Task<ActionResult<User>> RegisterUser(UserDto request)
        {
            var response = await _authService.RegisterUser(request);
            return Ok(response);
        }
    }
}
