using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicios
{
    public interface IPartidoService
    {
        void Crear(Partido partido);
        List<Partido> Listar();

        Partido ObtenerPartidoPorId(int id);

        List<Seleccion> ObtenerSelecciones();

        List<Seleccion> ObtenerSeleccionesClasificadas();

    }

    public class PartidoService : IPartidoService
    {
        private ProyectoWeb3Context _context;

        public PartidoService(ProyectoWeb3Context context)
        {
            _context = context;
        }

        public void Crear(Partido partido)
        {
            _context.Partidos.Add(partido);
            _context.SaveChanges();
        }

        public List<Partido> Listar()
        {
            return _context.Partidos.ToList();
        }

        public Partido ObtenerPartidoPorId(int id)
        {
            return _context.Partidos.Find(id);
        }

        public List<Seleccion> ObtenerSelecciones()
        {
            return _context.Seleccions.OrderBy(te => te.Seleccion1).ToList();
        }

        public List<Seleccion> ObtenerSeleccionesClasificadas()
        {
            return _context.Seleccions.Where(s => (bool)s.Clasificada).OrderBy(sc => sc.Seleccion1).ToList();
        }

    }
}
