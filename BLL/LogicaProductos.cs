using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaProductos
    {
        //atributos
        private ProductosTableAdapter productos = null;
        //propiedades
        private ProductosTableAdapter PRODUCTOS
        {
            get
            {
                if (productos == null)
                    productos = new ProductosTableAdapter();
                return productos;
            }
        }

        //metodos
        public DataTable ListarProductosActivos()
        {
            return PRODUCTOS.GetDataProductos();
        }//fin del metodo ListarEmpleadosActivos

        public DataTable ListarProductosInactivos()
        {
            return PRODUCTOS.GetDataProductosInactivos();
        }//fin del metodo ListarEmpleadosInactivos

        public string NuevoProducto(string nombre, string descripcion, decimal precio, int porcentaje, int idmarca, string model, int stock, int existencia, int idgarantia, int idcategoria, string fechaingreso, int idproveedor)
        {
            int existe;
            existe = Convert.ToInt32(PRODUCTOS.ScalarQueryExisteProducto(nombre));
            if (existe > 0)
                return "Error: el producto " + nombre + " ya existe previamente";
            else
            {
                PRODUCTOS.InsertQueryProducto(nombre, descripcion, precio, porcentaje, idmarca, model, stock, existencia, idgarantia, idcategoria, fechaingreso, idproveedor);
                return "El producto " + nombre + " ha sido agregado exitosamente";
            }
        }//fin del metodo NuevoEmpleado

        public string EditarProducto(string nombre, string descripcion, decimal precio, int porcentaje, int idmarca, string model, int stock, int existencia, int idgarantia, int idcategoria, string fechaingreso, int idproveedor, byte state, int id)
        {
            int existe;
            existe = Convert.ToInt32(PRODUCTOS.ScalarQueryExisteProducto(nombre));
            if (existe > 1)
                return "Error: el producto " + nombre + " ya existe previamente";
            else
            {
                PRODUCTOS.UpdateQueryProducto(nombre, descripcion, precio, porcentaje, idmarca, model, stock, existencia, idgarantia, idcategoria, fechaingreso, idproveedor, state, id);
                return "El producto " + nombre + " ha sido editado exitosamente";
            }
        }//fin del metodo EditarEmpleado

    }
}
