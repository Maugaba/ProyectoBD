using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaMetododePago
    {
        //atributos
        private MetodosDePagoTableAdapter metodo = null;

        //propiedades
        private MetodosDePagoTableAdapter METODO
        {
            get
            {
                if (metodo == null)
                    metodo = new MetodosDePagoTableAdapter();
                return metodo;
            }
        }

        //metodos

        /// <summary>
        /// Metodo que devuelve el listado de metodos de pago activos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarMetodosActivos()
        {
            return METODO.GetDataMetodosDePagoActivos();
        }//fin del metodo ListarMetodosActivos

        /// <summary>
        /// Metodo que devuelve el listado de metodos de pago inactivos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarMetodosInactivos()
        {
            return METODO.GetDataMetodosDePagoInactivos();
        }//fin del metodo ListarMetodosInactivos

        /// <summary>
        /// Metodo que nos sirve para crear un nuevo metodo de pago en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre del metodo de pago</param>
        /// <param name="descipcion">Refiere a la descripcion del metodo de pago</param>
        /// <returns></returns>
        public string NuevoMetodo(string nombre, string descipcion)
        {
            int existe;
            existe = Convert.ToInt32(METODO.ScalarQueryExisteMetodoDePago(nombre));
            if (existe > 0)
                return "Error: el metodo de pago " + nombre + " ya existe previamente";
            else
            {
                METODO.InsertQueryMetodoDePago(nombre, descipcion);
                return "El metodo de pago " + nombre + " se ha creado exitosamente";
            }
        }//fin del metodo NuevaMarca

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombre">Refiere al nombre del metodo de pago</param>
        /// <param name="descipcion">Refiere a la descripcion del metodo de pago</param>
        /// <param name="estado">Refiere al estado del metodo de pago</param>
        /// <param name="id">Refiere al id del metodo de pago</param>
        /// <returns></returns>
        public string EditarMetodo(string nombre, string descipcion, byte estado, int id)
        {
            int existe;
            existe = Convert.ToInt32(METODO.ScalarQueryExisteMetodoDePago(nombre));
            if (existe > 1)
                return "Error: el metodo de pago " + nombre + " ya existe previamente";
            else
            {
                METODO.UpdateQueryMetodoDePago(nombre, descipcion, estado, id);
                return "El metodo de pago " + nombre + " se ha editado exitosamente";
            }
        }//fin del metodo EditarMarca   
    }
}
