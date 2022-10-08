using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Email es requerido")]
        [EmailAddress(ErrorMessage = "Formato invalido")]
        public string Email { get; set; }


        [Required(ErrorMessage = "Contraseña es requerida")]
        [StringLength(10, ErrorMessage = "La contraseña no puede exceder los 20 caracteres de longitud")]
        public string Password { get; set; }

    }
}