using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaTiposClientes
    {   
        //atributos
        private TiposdeClientesTableAdapter tiposclientes = null;
        //propiedades
        private TiposdeClientesTableAdapter TIPOSClIENTES
        {
            get
            {
                if (tiposclientes == null)
                    tiposclientes = new TiposdeClientesTableAdapter();
                return tiposclientes;
            }
        }
        //metodos

        /// <summary>
        /// Nos retorna el listado de los empleados activos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarTiposdeclientes()
        {
            return TIPOSClIENTES.GetDataTiposdeClientesActivos();
        }//fin del metodo ListarEmpleadosActivos


        /// <summary>
        /// Nos retorna el listado de los empleados inactivos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarTiposdeClientesInactivos()
        {
            return TIPOSClIENTES.GetDataTiposdeClientesInactivos();
        }//fin del metodo ListarEmpleadosInactivos

    
        /// <summary>
        /// Creacion de un nuevo tipo de usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="porcentaje"></param>
        /// <returns></returns>
        public string Nuevotipodeusuario(string nombre, string descripcion, int porcentaje)
        {
            int existe;
            existe = Convert.ToInt32(TIPOSClIENTES.ScalarQueryTiposdeCliente(nombre));
            if (existe > 0)
                return "Error: el tipo de cliente " + nombre + " ya existe previamente";
            else
            {
                TIPOSClIENTES.InsertQueryTipodeCliente(nombre, descripcion, porcentaje);
                return "Se agregó el tipo de cliente " + nombre;
            }
        }///fin del metodo Crear Empleado


        public string EditarTipodeusuario(string nombre, string descripcion, int porcentaje, byte state, int id)
        {
            int existe;
            existe = Convert.ToInt32(TIPOSClIENTES.ScalarQueryTiposdeCliente(nombre));
            if (existe > 1)
                return "Error: el tipo de cliente " + nombre + " ya existe previamente";
            else
            {
                TIPOSClIENTES.UpdateQueryTiposdeCliente(nombre, descripcion, porcentaje, state, id);
                return "Se editó el tipo de cliente " + nombre;
            }
        }///fin del metodo EditarEmpleado
      

        
    }
}
