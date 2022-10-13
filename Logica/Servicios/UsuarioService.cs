using Entidades.Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Servicios
{
    public interface IUsuarioService
    {
        void Registrar(Usuario usuario);

        List<Usuario> Listar();

    }

    public class UsuarioService : IUsuarioService
    {
        private ProyectoWeb3Context _context;

        public UsuarioService(ProyectoWeb3Context context)
        {
            _context = context;
        }

        public void Registrar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
        }

        public List<Usuario> Listar()
        {
            return _context.Usuarios.ToList();
        }

    }
}
