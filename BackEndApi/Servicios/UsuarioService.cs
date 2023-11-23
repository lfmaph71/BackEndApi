using BackEndApi.Interfaces;
using BackEndApi.Models;

namespace BackEndApi.Servicios
{
    public class UsuarioService : IUsuarios
    {
        private readonly BdusuariosContext _bdusuariosContext;

        public UsuarioService(BdusuariosContext bdusuariosContext)
        {
            _bdusuariosContext = bdusuariosContext;
        }

        public int CrearUsuarios(Usuario usuario)
        {
            var resul = _bdusuariosContext.Usuarios.Add(usuario);
            _bdusuariosContext.SaveChanges();
            return (int)resul.State;
        }

        public int EditarUsuarios(Usuario usuario)
        {
            var resul = _bdusuariosContext.Usuarios.Update(usuario);
            _bdusuariosContext.SaveChanges();
            return (int)resul.State;
        }

        public int EliminarUsuario(int IdUsuario)
        {
            Usuario? usuario = _bdusuariosContext.Usuarios.Find(IdUsuario);
            var resul = _bdusuariosContext.Usuarios.Remove(usuario);
            _bdusuariosContext.SaveChanges();
            return (int)resul.State;
        }

        public Usuario listUsuarioId(int id)
        {
            return _bdusuariosContext.Usuarios.FirstOrDefault( m => m.IdUsuario == id);
        }

        public List<Usuario> listUsuarios()
        {
             return _bdusuariosContext.Usuarios.ToList();
        }
    }
}
