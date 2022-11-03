using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Entidades.Entidades
{
    [MetadataType(typeof(SeleccionModelMetaData))]
    public partial class Seleccion
    {

    }

    public class SeleccionModelMetaData
    {
 
       

        public int IdSeleccion { get; set; }
        public string Seleccion1 { get; set; } = null!;
        public string? Confederacion { get; set; }
        public bool? Clasificada { get; set; }

      
    }

}
