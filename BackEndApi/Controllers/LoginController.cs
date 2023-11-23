using BackEndApi.Interfaces;
using BackEndApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAutorizacion _autorizacion;

        public LoginController(IAutorizacion autorizacion)
        {
            _autorizacion = autorizacion;
        }

        [HttpPost,Route("ObtenerToken")]
        public async Task<IActionResult> getToken(UsuLogin usuLogin)
        {
            try
            {
                var resul = await _autorizacion.DevolverToken(usuLogin);
                if (resul == null)
                {
                    return Unauthorized();
                }
                return Ok(resul);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
