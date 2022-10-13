using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    public partial class Partido
    {
        public int IdPartido { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opcion")]
        public int IdSeleccion1 { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una opcion")]
        public int IdSeleccion2 { get; set; }

        [Required(ErrorMessage = "Debe ingresar una cantidad de goles")]
        [Range(0,15,ErrorMessage = "La cantidad ingresada no es valida")]
        public int GolesSeleccion1 { get; set; }

        [Required(ErrorMessage = "Debe ingresar una cantidad de goles")]
        [Range(0, 15, ErrorMessage = "La cantidad ingresada no es valida")]
        public int GolesSeleccion2 { get; set; }

        public virtual Seleccion IdSeleccion1Navigation { get; set; } = null!;
        public virtual Seleccion IdSeleccion2Navigation { get; set; } = null!;
    }
}
