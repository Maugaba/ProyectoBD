using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaProveedores
    {
        //atributos
        private ProveedoresTableAdapter proveedores = null;
        //propiedades
        private ProveedoresTableAdapter PROVEEDORES
        {
            get
            {
                if (proveedores == null)
                    proveedores = new ProveedoresTableAdapter();
                return proveedores;
            }
        }
        //metodos
        public DataTable ListarProveedoresActivos()
        {
            return PROVEEDORES.GetDataProveedores();
        }//fin del metodo ListarEmpleadosActivos
        public DataTable ListarProveedoresInactivos()
        {
            return PROVEEDORES.GetDataProveedoresInactivos();
        }//fin del metodo ListarEmpleadosInactivos

        public string NuevoProveedor(string nombre, string direccion, string telefono)
        {
            int existe;
            existe = Convert.ToInt32(PROVEEDORES.ScalarQueryExisteProveedor(nombre));
            if (existe > 0)
                return "Error: el proveedor " + nombre + " ya existe previamente";
            else
            {
                PROVEEDORES.InsertQueryProveedor(nombre, direccion, telefono);
                return "El proveedor " + nombre + " ha sido agregado exitosamente";
            }
        }//fin del metodo NuevoEmpleado

        public string EditarProveedor(string nombre, string direccion, string telefono, byte state, int id)
        {
            int existe;
            existe = Convert.ToInt32(PROVEEDORES.ScalarQueryExisteProveedor(nombre));
            if (existe > 1)
                return "Error: el proveedor " + nombre + " ya existe previamente";
            else
            {
                PROVEEDORES.UpdateQueryProveedor(nombre, direccion, telefono, state, id);
                return "El proveedor " + nombre + " ha sido editado exitosamente";
            }
        }//fin del metodo EditarEmpleado
    }
}
