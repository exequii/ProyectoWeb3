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

        Usuario? GetUsuarioPorId(int id);
        Usuario? GetUsuarioPorEmail(String email);
        Usuario? GetUsuario(Usuario usuario);

        Usuario? ValidateUsuarioRegistrado(Usuario usuario);
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

        public Usuario? GetUsuarioPorId(int id)
        {
            try
            {
                return _context.Usuarios.Find(id);
            }
            catch
            {
                return null;
            }
            
        }

        public Usuario? GetUsuario(Usuario usuario)
        {
            try
            {
                return _context.Usuarios.Where(u => u.Email == usuario.Email && u.Contraseña == usuario.Contraseña).First();
            }
            catch
            {
                return null;
            }

        }

        public Usuario? ValidateUsuarioRegistrado(Usuario usuario)
        {
            try
            {
                return _context.Usuarios.Where(u => u.Email == usuario.Email).First();
            }
            catch
            {
                return null;
            }
        }

        public Usuario? GetUsuarioPorEmail(string email)
        {

            if(email == null | email == "")
            {
                return null;
            }
            var usuario = from u in _context.Usuarios
                              where u.Email == email
                              select u;

            return usuario.First();
            
            
        }
    }
}
