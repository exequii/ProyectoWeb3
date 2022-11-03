using System;
using System.Collections.Generic;

namespace Entidades.Entidades
{
    public partial class Usuario
    {
        public int IdUsuario { get; set; }
        public string Email { get; set; } = null!;
        public string Contraseña { get; set; } = null!;
    }
}
