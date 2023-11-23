using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BackEndApi.Interfaces;
using BackEndApi.Models;

namespace BackEndApi.Servicios
{
    public class AutorizacionService : IAutorizacion
    {
        private readonly BdusuariosContext _bdusuariosContext;
        private readonly IConfiguration _configuration;

        public AutorizacionService(BdusuariosContext bdusuariosContext, IConfiguration configuration)
        {
            _bdusuariosContext = bdusuariosContext;
            _configuration = configuration;
        }

        private string GenerarToken(string idUsuario)
        {
            var key = _configuration.GetValue<string>("JWTSetting:Key");
            var keyBytes = Encoding.ASCII.GetBytes(key); //convertirlo en un array

            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.NameIdentifier, idUsuario));

            var credencialesToken = new SigningCredentials(
                new SymmetricSecurityKey(keyBytes),
                SecurityAlgorithms.HmacSha256Signature
                );

            var TokenDescripcion = new SecurityTokenDescriptor
            {
                Subject= claims,
                Expires= DateTime.UtcNow.AddSeconds(350),
                SigningCredentials= credencialesToken
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenConfig = tokenHandler.CreateToken(TokenDescripcion);

            string token = tokenHandler.WriteToken(tokenConfig);

            return token;

        }

        public async Task<AutorizacionResponse> DevolverToken(UsuLogin usuLogin)
        {
            var buscarUsuario = _bdusuariosContext.UsuLogins.FirstOrDefault(x=>
                x.NombreUsuario == usuLogin.NombreUsuario &&
                x.Clave == usuLogin.Clave
            );

            if (buscarUsuario == null)
            {
                return await Task.FromResult<AutorizacionResponse>(null); 
            }

            string token = GenerarToken(buscarUsuario.IdUsuLogin.ToString());

            return new AutorizacionResponse()
            {
                Token= token,
                Resultado = true,
                Msg = "OK"
            };

        }
    }
}
