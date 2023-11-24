using BackEndApi.Interfaces;
using BackEndApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackEndApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarios _isuarios;
        public UsuariosController(IUsuarios usuarios)
        {
            _isuarios= usuarios;
        }

        //[Authorize]
        [HttpGet, Route("ListarUsuarios")]
        public IActionResult listarUsuarios()
        {
            List<Usuario> listUsuario= new List<Usuario>();
            try
            {
                return Ok(_isuarios.listUsuarios());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize]
        [HttpGet, Route("ListarUsuariosId/{id}")]
        public IActionResult listarUsuariosId(int id)
        {
            try
            {
                return Ok(_isuarios.listUsuarioId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize]
        [HttpPost,Route("CrearUsuarios")]
        public IActionResult crearUsuarios(Usuario usuario)
        {
            try
            {
                return Ok(_isuarios.CrearUsuarios(usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize]
        [HttpPost, Route("EditarUsuarios")]
        public IActionResult editarUsuarios(Usuario usuario)
        {
            try
            {
                return Ok(_isuarios.EditarUsuarios(usuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize]
        [HttpPost, Route("EliminarUsuarios")]
        public IActionResult eliminarUsuarios(int idUsuario)
        {
            try
            {
                return Ok(_isuarios.EliminarUsuario(idUsuario));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
