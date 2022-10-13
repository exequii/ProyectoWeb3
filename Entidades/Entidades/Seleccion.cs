using System;
using System.Collections.Generic;

namespace Entidades.Entidades
{
    public partial class Seleccion
    {
        public Seleccion()
        {
            GrupoIdSeleccion1Navigations = new HashSet<Grupo>();
            GrupoIdSeleccion2Navigations = new HashSet<Grupo>();
            GrupoIdSeleccion3Navigations = new HashSet<Grupo>();
            GrupoIdSeleccion4Navigations = new HashSet<Grupo>();
            PartidoIdSeleccion1Navigations = new HashSet<Partido>();
            PartidoIdSeleccion2Navigations = new HashSet<Partido>();
        }

        public int IdSeleccion { get; set; }
        public string Seleccion1 { get; set; } = null!;
        public string? Confederacion { get; set; }
        public bool? Clasificada { get; set; }

        public virtual ICollection<Grupo> GrupoIdSeleccion1Navigations { get; set; }
        public virtual ICollection<Grupo> GrupoIdSeleccion2Navigations { get; set; }
        public virtual ICollection<Grupo> GrupoIdSeleccion3Navigations { get; set; }
        public virtual ICollection<Grupo> GrupoIdSeleccion4Navigations { get; set; }
        public virtual ICollection<Partido> PartidoIdSeleccion1Navigations { get; set; }
        public virtual ICollection<Partido> PartidoIdSeleccion2Navigations { get; set; }
    }
}
