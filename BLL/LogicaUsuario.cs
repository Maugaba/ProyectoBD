using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;
using System.Security.Cryptography;

namespace BLL
{
    public class LogicaUsuario
    {   
        //atributos
        private UsuariosTableAdapter usuarios = null;

        //propiedades
        private UsuariosTableAdapter USUARIOS
        {
            get
            {
                if (usuarios == null)
                    usuarios = new UsuariosTableAdapter();
                return usuarios;
            }
        }

        //metodos

        /// <summary>
        /// Nos retorna el listado de los usuarios activos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarUsuariosActivos()
        {
            return USUARIOS.GetDataUsuariosActivos();
        }//fin del metodo ListarUsuariosActivos

        /// <summary>
        /// Nos retorna el listado de los usuarios inactivos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarUsuariosInactivos()
        {
            return USUARIOS.GetDataUsuariosInactivos();
        }//fin del metodo ListarUsuariosInactivos

        /// <summary>
        /// Este metodo nos crear un nuevo usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Refiere al nombre del usuario</param>
        /// <param name="contraseña">Refiere a la contraseña del usuario</param>
        /// <param name="idRol">Refiere al Rol que se la asignara al usuario</param>
        /// <param name="idEmpleado">Refiere al Empleado que se la asignara al usuario</param>
        /// <returns></returns>
        public string NuevoUsuario(string usuario, string contraseña, int idRol, int idEmpleado)
        {
            string contraseñaUsuario = contraseña;
            string hashContraseña = CifrarContraseña(contraseñaUsuario);
            int existe;
            existe = Convert.ToInt32(USUARIOS.ScalarQueryExisteUsuario(usuario));
            if (existe > 0)
                return "Error: el usuario " + usuario + " ya existe previamente";
            else
            {
                try
                {
                    USUARIOS.InsertQueryUsuario(usuario, hashContraseña, idRol, idEmpleado);
                    return "Se agregó el usuario " + usuario;
                }
                catch (Exception)
                {
                    return "El empleado al que intentas crear un usuario ya posee un usuario previamente ";
                }
                
            }
        }//fin del metodo NuevoUsuario

        /// <summary>
        /// Este metodo nos permite actualizar un usuario en la base de datos
        /// </summary>
        /// <param name="usuario">Refiere al nombre del usuario</param>
        /// <param name="idRol">Refiere al rol que posee el usuario</param>
        /// <param name="estado">Refiere al estado actual del usuario</param>
        /// <param name="id">Refiere al identificador del usuario que se editara</param>
        /// <param name="idEmpleado">Refiere al empleado del usuario que se editara</param>
        /// <returns></returns>
        public string EditarUsuario(string usuario, int idRol, byte estado, int id, int idEmpleado)
        {
            int existe;
            existe = Convert.ToInt32(USUARIOS.ScalarQueryExisteUsuario(usuario));
            if (existe > 1)
                return "Error: el usuario " + usuario + " ya existe previamente";
            else
            {
                USUARIOS.UpdateQueryUsuario(usuario, idRol, estado, idEmpleado, id);
                return "Se editó el usuario con registro: " + id;
            }
        }//fin del metodo EditarUsuario

        /// <summary>
        /// Este metodo nos permite cambiar la contraseña de un usuario
        /// </summary>
        /// <param name="contraseña">Refiere a la contraseña del usuario</param>
        /// <param name="id">Refiere al identificador del usuario al que se le cambiara la contraseña</param>
        /// <returns></returns>
        public string CambiarContraseña(string contraseña, int id)
        {
            string contraseñaUsuario = contraseña;
            string hashContraseña = CifrarContraseña(contraseñaUsuario);
            USUARIOS.UpdateQueryCambiarContraseñaUsuario(hashContraseña, id);
            return "La contraseña del usuario con registro: " + id + " ha sido actualizada";
        }//fin del metodo CambiarContraseña

        /// <summary>
        /// Este metodo nos permite encriptar una contraseña para que no se guarde en texto plano y hacerla irreversible
        /// </summary>
        /// <param name="contraseña">Refiere a la contraseña a encriptar</param>
        /// <returns></returns>
        static string CifrarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }//fin del metodo CifrarContraseña

    }
}
