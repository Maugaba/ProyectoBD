using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaEmpleado
    {   
        //atributos
        private EmpleadosTableAdapter empleados = null;

        //propiedades
        private EmpleadosTableAdapter EMPLEADOS
        {
            get
            {
                if (empleados == null)
                    empleados = new EmpleadosTableAdapter();
                return empleados;
            }
        }

        //metodos

        /// <summary>
        /// Nos retorna el listado de los empleados activos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarEmpleadosActivos()
        {
            return EMPLEADOS.GetDataEmpleadosActivos();
        }//fin del metodo ListarEmpleadosActivos


        /// <summary>
        /// Nos retorna el listado de los empleados inactivos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarEmpleadosInactivos()
        {
            return EMPLEADOS.GetDataEmpleadosInactivos();
        }//fin del metodo ListarEmpleadosInactivos

        /// <summary>
        /// Este metodo nos crea un nuevo empleado en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre del empleado</param>
        /// <param name="apellido">Refiere al apellido del empleado</param>
        /// <param name="fecha">Refiere a la fecha de nacimiento del empleado</param>
        /// <param name="genero">Refiere al genero del empleado</param>
        /// <param name="dpi">Refiere al dpi del empleado</param>
        /// <param name="direccion">Refiere a la direccion del empleado</param>
        /// <param name="telefono">Refiere al telefono del empleado</param>
        /// <returns></returns>
        public string NuevoEmpleado(string nombre, string apellido, string fecha, string genero, string dpi , string direccion, string telefono)
        {
            int existe;
            existe = Convert.ToInt32(EMPLEADOS.ScalarQueryExisteEmpleado(dpi));
            if (existe > 0)
                return "Error: el empleado con el dpi " + dpi + " ya existe previamente";
            else
            {
                EMPLEADOS.InsertQueryEmpleado(nombre, apellido, fecha, genero, dpi, direccion , telefono);
                return "Se agregó el empleado con el dpi " + dpi;
            }
        }//fin del metodo NuevoEmpleado

        /// <summary>
        /// Este metodo edita un empleado en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre del empleado</param>
        /// <param name="apellido">Refiere al apellido del empleado</param>
        /// <param name="fecha">Refiere a la fecha de nacimiento del empleado</param>
        /// <param name="genero">Refiere al genero del empleado</param>
        /// <param name="dpi">Refiere al dpi del empleado</param>
        /// <param name="direccion">Refiere a la direccion del empleado</param>
        /// <param name="telefono">Refiere al telefono del empleado</param>
        /// <returns></returns>
        public string EditarEmpleado(string nombre, string apellido, string fecha, string genero, string dpi, string direccion, string telefono, byte estado, int id)
        {
            int existe;
            existe = Convert.ToInt32(EMPLEADOS.ScalarQueryExisteEmpleado(dpi));
            if (existe > 1)
                return "Error: el empleado con el dpi " + dpi + " ya existe previamente";
            else
            {
                EMPLEADOS.UpdateQueryEmpleado(nombre, apellido, fecha, genero, dpi, direccion, telefono, estado, id);
                return "Se editó el empleado con registro: " + id;
            }
        }//fin del metodo EditarEmpleadoW

        
    }
}
