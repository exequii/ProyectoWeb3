using System;
using System.Collections.Generic;

namespace Entidades.Entidades
{
    public partial class Grupo
    {
        public int IdGrupo { get; set; }
        public string Grupo1 { get; set; } = null!;
        public int IdSeleccion1 { get; set; }
        public int IdSeleccion2 { get; set; }
        public int IdSeleccion3 { get; set; }
        public int IdSeleccion4 { get; set; }

        public virtual Seleccion IdSeleccion1Navigation { get; set; } = null!;
        public virtual Seleccion IdSeleccion2Navigation { get; set; } = null!;
        public virtual Seleccion IdSeleccion3Navigation { get; set; } = null!;
        public virtual Seleccion IdSeleccion4Navigation { get; set; } = null!;
    }
}
