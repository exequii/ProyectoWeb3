using System;
using System.Collections.Generic;

namespace Entidades.Entidades
{
    public partial class Partido
    {

        public int IdPartido { get; set; }
        public int IdSeleccion1 { get; set; }
        public int IdSeleccion2 { get; set; }
        public int GolesSeleccion1 { get; set; }
        public int GolesSeleccion2 { get; set; }

        public virtual Seleccion IdSeleccion1Navigation { get; set; } = null!;
        public virtual Seleccion IdSeleccion2Navigation { get; set; } = null!;
    }
}
