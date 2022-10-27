using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    [MetadataType(typeof(PartidoModelMetaData))]
    public partial class Partido
    {
        public Partido() { }
    }

    public class PartidoModelMetaData
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
