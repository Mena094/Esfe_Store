using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esfe.StoreDAL;
using Esfe.Store.EN;

namespace Esfe.StoreBL
{
    public class UsuarioBL
    {
        public static int Guardar(UsuarioEN pUsuario)
        {
            return UsuarioDAL.Guardar(pUsuario);
        }

        public static int Modificar(UsuarioEN pUsuario)
        {
            return UsuarioDAL.Modificar(pUsuario);
        }

        public static int Eliminar(UsuarioEN pUsuario)
        {
            return UsuarioDAL.Eliminar(pUsuario);
        }

        public static List<UsuarioEN> ObtenerTodos()
        {
            return UsuarioDAL.ObtenerTodos();
        }

        public static UsuarioEN BuscarPorId(int pId)
        {
            return UsuarioDAL.BuscarPorId(pId);
        }

        public static List<UsuarioEN> Buscar(UsuarioEN pUsuario)
        {
            return UsuarioDAL.Buscar(pUsuario);
        }

        public static UsuarioEN Login(string correoElectronico, string contraseña)
        {
            return UsuarioDAL.Login(correoElectronico, contraseña);
        }
    }
}
