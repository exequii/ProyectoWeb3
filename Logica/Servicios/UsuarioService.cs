using Entidades;
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
        private List<Usuario> List { set; get; } = new List<Usuario>();

        public int ObtenerMaxId()
        {
            if (List.Count == 0)
                return 0;

            return List.Max(o => o.Id);
        }

        public void Registrar(Usuario usuario)
        {
            usuario.Id = ObtenerMaxId() + 1;
            List.Add(usuario);
        }

        public List<Usuario> Listar()
        {
            return List;
        }
    }
}
