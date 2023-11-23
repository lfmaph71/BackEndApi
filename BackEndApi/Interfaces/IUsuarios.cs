using BackEndApi.Models;

namespace BackEndApi.Interfaces
{
    public interface IUsuarios
    {
        List<Usuario> listUsuarios();
        Usuario listUsuarioId(int id);
        int CrearUsuarios(Usuario usuario);
        int EditarUsuarios(Usuario usuario);
        int EliminarUsuario(int IdUsuario);
    }
}
