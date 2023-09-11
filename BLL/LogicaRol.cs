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
    public class LogicaRol
    {   
        //atributos
        private RolesTableAdapter roles = null;
        private RolesPermisosTableAdapter permisos = null;
        
        //propiedades
        private RolesTableAdapter ROLES
        {
            get
            {
                if (roles == null)
                    roles = new RolesTableAdapter();
                return roles;
            }
        }
        private RolesPermisosTableAdapter PERMISOS
        {
            get
            {
                if (permisos == null)
                    permisos = new RolesPermisosTableAdapter();
                return permisos;
            }
        }

        //metodos

        /// <summary>
        /// Nos retorna el listado de los roles activos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarRolesActivos()
        {
            return ROLES.GetDataRolesActivos();
        }//fin del metodo ListarRolesActivos

        /// <summary>
        /// Nos retorna el listado de los roles inactivos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarUsuariosInactivos()
        {
            return ROLES.GetDataRolesInactivos();
        }//fin del metodo ListarRolesInactivos

        /// <summary>
        /// Este metodo nos sirve para crear un nuevo rol en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre del rol</param>
        /// <param name="descripcion">Refiere a una descripcion del uso del rol</param>
        /// <returns></returns>
        public string NuevoRol(string nombre, string descripcion){
            int existe;
            existe = Convert.ToInt32(ROLES.ScalarQueryExisteRol(nombre));
            if (existe > 0)
                return "Error: el rol " + nombre + " ya existe previamente";
            else
            {
                ROLES.InsertQueryRol(nombre, descripcion);
                return "Se agregó el rol " + nombre + ", Ahora puedes elegir que permisos tiene este rol";
            }
        }//fin del metodo NuevoRol

        /// <summary>
        /// Este metodo nos sirve para editar el rol en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre del rol</param>
        /// <param name="descripcion">Refiere a la descripcion del uso del rol</param>
        /// <param name="estado">Refiere al estado en el que se encuentra el Rol</param>
        /// <param name="id">Refiere al identificador del rol</param>
        /// <returns></returns>
        public string EditarRol(string nombre, string descripcion, byte estado, int id)
        {
            int existe;
            existe = Convert.ToInt32(ROLES.ScalarQueryExisteRol(nombre));
            if (existe > 1)
                return "Error: el rol " + nombre + " ya existe previamente";
            else
            {
                ROLES.UpdateQueryRol(nombre, descripcion, estado, id);
                return "Se editó el rol con registro: " + id + ", ahora puede editar sus permisos";
            }
        }//fin del metodo EditarRol

        /// <summary>
        /// Metodo que nos sirve para obtener el id de un rol
        /// </summary>
        /// <param name="nombre">Refiere al nombre del rol</param>
        /// <returns></returns>
        public int ObtenerIdRol(string nombre)
        {
            return Convert.ToInt32(ROLES.ScalarQueryEncontrarId(nombre));
        }//fin del metodo ObtenerIdRol

        /// <summary>
        /// Metodo que nos sirve para obtener el nombre de un rol
        /// </summary>
        /// <param name="id">Id para saber los permisos de ese rol</param>
        /// <returns></returns>
        public DataTable ListarPermisos(int id)
        {
            return PERMISOS.GetDataPermisos(id);
        }

        /// <summary>
        /// Metodo que nos sirve para crear un nuevo permiso en la base de datos
        /// </summary>
        /// <param name="rol">El rol al que se añadira permiso</param>
        /// <param name="idperm">El permiso que se le añadira</param>
        /// <param name="permiso">El estado del permiso</param>
        /// <returns></returns>
        public string NuevoPermiso(int rol, int idperm, byte permiso)
        {
            PERMISOS.InsertQueryPerms(rol, idperm, permiso);
            return "Se creo el permiso";
        }

        /// <summary>
        /// Metodo que nos sirve para editar un permiso en la base de datos
        /// </summary>
        /// <param name="estado">El estado al permiso que se cambiara</param>
        /// <param name="idperm">El id del permiso a cambiar</param>
        /// <returns></returns>
        public string EditarPermiso(byte estado,int idperm)
        {
            PERMISOS.UpdateQueryPermisos(estado, idperm);
            return "Se edito el permiso";
        }

    }
}
