using Esfe.Store.EN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfe.StoreDAL
{
    public class UsuarioDAL
    {
       
        public static int Guardar(UsuarioEN pUsuario)
        {
            string consulta = "INSERT INTO Usuarios (Nombre, Apellido, CorreoElectronico, Contraseña) VALUES (@Nombre, @Apellido, @CorreoElectronico, @Contraseña)";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pUsuario.Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", pUsuario.CorreoElectronico);
            comando.Parameters.AddWithValue("@Contraseña", pUsuario.Contraseña);

            return ComunDB.EjecutarComando(comando);
        }

        public static int Modificar(UsuarioEN pUsuario)
        {
            string consulta = "UPDATE Usuarios SET Nombre=@Nombre, Apellido=@Apellido, CorreoElectronico=@CorreoElectronico, Contraseña=@Contraseña WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", pUsuario.Nombre);
            comando.Parameters.AddWithValue("@Apellido", pUsuario.Apellido);
            comando.Parameters.AddWithValue("@CorreoElectronico", pUsuario.CorreoElectronico);
            comando.Parameters.AddWithValue("@Contraseña", pUsuario.Contraseña);
            comando.Parameters.AddWithValue("@Id", pUsuario.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static int Eliminar(UsuarioEN pUsuario)
        {
            string consulta = "DELETE FROM Usuarios WHERE Id=@Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pUsuario.Id);
            return ComunDB.EjecutarComando(comando);
        }
        public static List<UsuarioEN> ObtenerTodos()
        {
            string consulta = "SELECT Id, Nombre, Apellido, CorreoElectronico, Contraseña FROM Usuarios";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<UsuarioEN> ListaUsuarios = new List<UsuarioEN>();
            while (reader.Read())
            {
                UsuarioEN usuario = new UsuarioEN();
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.CorreoElectronico = reader.GetString(3);
                usuario.Contraseña = reader.GetString(4);
                ListaUsuarios.Add(usuario);
            }
            comando.Connection.Dispose();
            return ListaUsuarios;
        }
        public static UsuarioEN BuscarPorId(int pId)
        {
            string consulta = "SELECT Id, Nombre, Apellido, CorreoElectronico, Contraseña FROM Usuarios WHERE Id = @Id";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Id", pId);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            UsuarioEN usuario = null;
            if (reader.Read())
            {
                usuario = new UsuarioEN();
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.CorreoElectronico = reader.GetString(3);
                usuario.Contraseña = reader.GetString(4);
            }
            comando.Connection.Dispose();
            return usuario;
        }
        public static List<UsuarioEN> Buscar(UsuarioEN pUsuario)
        {
            string consulta = "SELECT Id, Nombre, Apellido, CorreoElectronico, Contraseña FROM Usuarios WHERE Nombre LIKE @Nombre";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@Nombre", "%" + pUsuario.Nombre + "%");
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            List<UsuarioEN> ListaUsuarios = new List<UsuarioEN>();
            while (reader.Read())
            {
                var usuario = new UsuarioEN();
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.CorreoElectronico = reader.GetString(3);
                usuario.Contraseña = reader.GetString(4);
                ListaUsuarios.Add(usuario);
            }
            comando.Connection.Dispose();
            return ListaUsuarios;
        }
        public static UsuarioEN Login(string correoElectronico, string contraseña)
        {
            string consulta = "SELECT Id, Nombre, Apellido, CorreoElectronico, Contraseña FROM Usuarios WHERE CorreoElectronico = @CorreoElectronico AND Contraseña = @Contraseña";
            SqlCommand comando = ComunDB.ObtenerComando();
            comando.CommandText = consulta;
            comando.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
            comando.Parameters.AddWithValue("@Contraseña", contraseña);
            SqlDataReader reader = ComunDB.EjecutarComandoReader(comando);
            UsuarioEN usuario = null;
            if (reader.Read())
            {
                usuario = new UsuarioEN();
                usuario.Id = reader.GetInt32(0);
                usuario.Nombre = reader.GetString(1);
                usuario.Apellido = reader.GetString(2);
                usuario.CorreoElectronico = reader.GetString(3);
                usuario.Contraseña = reader.GetString(4);
            }
            comando.Connection.Dispose();
            return usuario;
        }
    }
}
