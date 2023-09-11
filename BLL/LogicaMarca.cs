using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaMarca
    {
        //atributos
        private MarcasTableAdapter marcas = null;

        //propiedades
        private MarcasTableAdapter MARCAS
        {
            get
            {
                if (marcas == null)
                    marcas = new MarcasTableAdapter();
                return marcas;
            }
        }

        //metodos

        /// <summary>
        /// Devuelve el listado de marcas activas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarMarcasActivas()
        {
            return MARCAS.GetDataMarcasActivas();
        }//fin del metodo ListarMarcasActivas

        /// <summary>
        /// Devuelve el listado de marcas inactivas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarMarcasInactivas()
        {
            return MARCAS.GetDataMarcasInactivas();
        }//fin del metodo ListarMarcasInactivas

        /// <summary>
        /// Este metodo nos sirve para crear una nueva marca en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere a el nombre de la marca</param>
        /// <param name="descipcion">Refiere a una descripcion de la marca</param>
        /// <returns></returns>
        public string NuevaMarca(string nombre, string descipcion)
        {
            int existe;
            existe = Convert.ToInt32(MARCAS.ScalarQueryExisteMarca(nombre));
            if (existe > 0)
                return "Error: la marca " + nombre + " ya existe previamente";
            else
            {
                MARCAS.InsertQueryMarca(nombre, descipcion);
                return "La marca " + nombre + " se ha creado exitosamente";
            }
        }//fin del metodo NuevaMarca

        /// <summary>
        /// Este metodo nos sirve para editar una marca en la base de datos
        /// </summary>
        /// <param name="nombre">Refiere al nombre de la marca</param>
        /// <param name="descripcion">Refiere a la descripcion de la marca</param>
        /// <param name="estado">Refiere al estado en el que se encuentra la marca</param>
        /// <param name="id">Refiere al id de la marca</param>
        /// <returns></returns>
        public string EditarMarca(string nombre, string descripcion,  byte estado, int id)
        {
            int existe;
            existe = Convert.ToInt32(MARCAS.ScalarQueryExisteMarca(nombre));
            if (existe > 1)
                return "Error: la marca " + nombre + " ya existe previamente";
            else
            {
                MARCAS.UpdateQueryMarca(nombre, descripcion, estado, id);
                return "La marca " + nombre + " se ha editado exitosamente";
            }
        }//fin del metodo EditarMarca
    }
}
