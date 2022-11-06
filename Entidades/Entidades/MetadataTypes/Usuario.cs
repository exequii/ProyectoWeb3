using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Entidades
{
    [MetadataType(typeof(UsuarioModelMetaData))]
    public partial class Usuario
    {
        public Usuario()
        {
            Partidos = new HashSet<Partido>();
        }
    }

    public class UsuarioModelMetaData
    {
        public UsuarioModelMetaData()
        {
            Partidos = new HashSet<Partido>();
        }
        public int IdUsuario { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [EmailAddress(ErrorMessage = "Formato invalido")]
        public string Email { get; set; } = null!;


        [Required(ErrorMessage = "Contraseña es requerida")]
        [StringLength(20, ErrorMessage = "La contraseña no puede exceder los 20 caracteres de longitud")]
        public string Contraseña { get; set; } = null!;

        public virtual ICollection<Partido> Partidos { get; set; }
    }

}
