using System;
using System.Collections.Generic;

namespace BackEndApi.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombres { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public int Edad { get; set; }
}
