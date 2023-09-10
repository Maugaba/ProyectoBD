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
                return "Se agregó el rol " + nombre;
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
                return "Se editó el rol con registro: " + id;
            }
        }//fin del metodo EditarRol
    }
}
