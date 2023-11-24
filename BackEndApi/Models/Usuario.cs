using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BackEndApi.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    [Required(ErrorMessage ="Nombre es Requerido")]
    [MaxLength(100,ErrorMessage ="El nombre Tiene mas de 100 caracteres")]
    public string Nombres { get; set; } = null!;

    [Required(ErrorMessage ="Correo es Requerido")]
    [MaxLength(50,ErrorMessage ="El nombre Tiene mas de 100 caracteres")]
    public string Correo { get; set; } = null!;

    [Required(ErrorMessage ="Edad es Requerido")]
    public int Edad { get; set; }
}
