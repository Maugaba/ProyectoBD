using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaGarantia
    {
        //atributos
        private GarantíasTableAdapter garantías = null;

        //propiedades
        private GarantíasTableAdapter GARANTIAS
        {
            get
            {
                if (garantías == null)
                    garantías = new GarantíasTableAdapter();
                return garantías;
            }
        }

        //metodos
        /// <summary>
        /// Nos devuelve el listado de garantias activas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarGarantiasActivas()
        {
            return GARANTIAS.GetDataGarantíasActivas();
        }//fin del metodo ListarGarantiasActivas

        /// <summary>
        /// Nos devulve el listado de garantias inactivas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarGarantiasInactivas()
        {
            return GARANTIAS.GetDataGarantíasInactivas();
        }//fin del metodo ListarGarantiasInactivas

        /// <summary>
        /// Este metodo nos sirve para crear una nueva garantia en la base de datos
        /// </summary>
        /// <param name="tiempo">Refiere al tiempo de la garantia</param>
        /// <returns></returns>
        public string NuevaGarantia(int tiempo)
        {
            int existe;
            existe = Convert.ToInt32(GARANTIAS.ScalarQueryExisteGarantía(tiempo));
            if (existe > 0)
                return "Error: la garantia " + tiempo + " ya existe previamente";
            else
            {
                GARANTIAS.InsertQueryGarantía(tiempo);
                return "La garantia " + tiempo + " se ha creado exitosamente";
            }
        }//fin del metodo NuevaMarca

        /// <summary>
        /// Metodo que nos permite modificar una garantia
        /// </summary>
        /// <param name="tiempo">Refiere al tiempo de garantia</param>
        /// <param name="estado">Refiere al estado en el que se encuentra</param>
        /// <param name="id">REfiere al identificador de la garantía</param>
        /// <returns></returns>
        public string ModificarGarantia(int tiempo, byte estado, int id)
        {
            int existe;
            existe = Convert.ToInt32(GARANTIAS.ScalarQueryExisteGarantía(tiempo));
            if (existe > 1)
                return "Error: la garantia " + tiempo + " ya existe previamente";
            else
            {
                GARANTIAS.UpdateQueryGarantía(tiempo, estado, id);
                return "La garantia " + tiempo + " se ha modificado exitosamente";
            }
        }//fin del metodo ModificarGarantia


    }
}
