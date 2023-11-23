using BackEndApi.Models;

namespace BackEndApi.Interfaces
{
    public interface IAutorizacion
    {
        Task<AutorizacionResponse> DevolverToken(UsuLogin usuLogin);

    }
}
