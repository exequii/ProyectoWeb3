using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface IUsuarioService
    {
        void Registrar(Usuario usuario);

        List<Usuario> Listar();
    }

    public class UsuarioService : IUsuarioService
    {
        private List<Usuario> List { set; get; } = new List<Usuario>();

        public int ObtenerMaxId()
        {
            return 0;
        }

        public void Registrar(Usuario usuario)
        {
            usuario.Id = ObtenerMaxId()+1;
            List.Add(usuario);
        }

        public List<Usuario> Listar()
        {
            return List;
        }
    }
}
