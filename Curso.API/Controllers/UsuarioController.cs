using Curso.API.Models.Usuarios;
using Microsoft.AspNetCore.Mvc;
namespace Curso.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class UsuarioController : ControllerBase
  {
    [HttpPost]
    public IActionResult Logar(LoginViewModelInput loginViewModelInput)
    {
      return Created("", loginViewModelInput);
    }

    [HttpPost]
    public IActionResult Registar(LoginViewModelInput loginViewModelInput)
    {
      return Created("", loginViewModelInput);
    }
  }
}
