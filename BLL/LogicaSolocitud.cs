using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaSolocitud
    {
        //atributos
        private SolicitudProductosaProveedoresTableAdapter solicitudes = null;
        //propiedades
        private SolicitudProductosaProveedoresTableAdapter SOLICITUDES
        {
            get
            {
                if (solicitudes == null)
                    solicitudes = new SolicitudProductosaProveedoresTableAdapter();
                return solicitudes;
            }
        }

        //metodos
        public DataTable ListarSolicitudesActivas()
        {
            return SOLICITUDES.GetDataSolicitud();
        }//fin del metodo ListarEmpleadosActivos

        public DataTable ListarSolicitudesInactivas()
        {
            return SOLICITUDES.GetDataSolicitudInactivos();
        }//fin del metodo ListarEmpleadosInactivos

        public DataTable ListarSolicitudesCompletadas()
        {
            return SOLICITUDES.GetDataCompletados();
        }//fin del metodo ListarEmpleados

        public string NuevaSolicitud(int producto, int proveedores, int cantidad)
        {
            SOLICITUDES.InsertQuerySolicitud(producto, proveedores, cantidad);
            return "La solicitud del producto ha sido agregada exitosamente";
        }//fin del metodo NuevoEmpleado

        public string EditarSolicitud(int producto, int proveedores, int cantidad, byte state, int id)
        {
            SOLICITUDES.UpdateQuerySolicitud(producto, proveedores, cantidad, state, id);
            return "La solicitud del producto ha sido editada exitosamente";
        }//fin del metodo EditarEmpleado

    }
}
