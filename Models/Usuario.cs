using System;
using System.Collections.Generic;

namespace ApiRealState.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public string Contraseña { get; set; } = null!;

    public int Rol { get; set; }

    public virtual Role RolNavigation { get; set; } = null!;
}
