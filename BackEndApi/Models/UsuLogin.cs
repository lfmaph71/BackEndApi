using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class UsuLogin
{
    public int IdUsuLogin { get; set; }

    public string NombreUsuario { get; set; } = null!;

    public string Clave { get; set; } = null!;
}
