using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaCategoria
    {
        //atributos
        private CategoríasTableAdapter categorias = null;
        //propiedades
        private CategoríasTableAdapter CATEGORIAS
        {
            get
            {
                if (categorias == null)
                    categorias = new CategoríasTableAdapter();
                return categorias;
            }
        }

        //metodos
        public DataTable ListarCategoriasActivas()
        {
            return CATEGORIAS.GetDataCategorias();
        }//fin del metodo ListarEmpleadosActivos

        public DataTable ListarCategoriasInactivas()
        {
            return CATEGORIAS.GetDataCategoriasInactivas();
        }//fin del metodo ListarEmpleadosInactivos

        public string NuevaCategoria(string nombre, string descripcion)
        {
            int existe;
            existe = Convert.ToInt32(CATEGORIAS.ScalarQueryExisteCategoria(nombre));
            if (existe > 0)
                return "Error: la categoria " + nombre + " ya existe previamente";
            else
            {
                CATEGORIAS.InsertQueryCategorias(nombre, descripcion);
                return "La categoria " + nombre + " ha sido agregada exitosamente";
            }
        }//fin del metodo NuevoEmpleado

        public string EditarCategoria(string nombre, string descripcion, byte state, int id)
        {
            int existe;
            existe = Convert.ToInt32(CATEGORIAS.ScalarQueryExisteCategoria(nombre));
            if (existe > 1)
                return "Error: la categoria " + nombre + " ya existe previamente";
            else
            {
                CATEGORIAS.UpdateQueryCategoria(nombre, descripcion, state, id);
                return "La categoria " + nombre + " ha sido editada exitosamente";
            }
        }//fin del metodo EditarEmpleado

    }
}
