using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaVentas
    {
        //atributos
        private VentasTableAdapter ventas = null;
        private func_ListarProductosVentasTableAdapter func_ListarProductosVentasTableAdapter = null;
        private func_ListarVentaIndividualTableAdapter func_ListarVentaIndividualTableAdapter = null;
        //propiedades
        private VentasTableAdapter VENTAS
        {
            get
            {
                if (ventas == null)
                    ventas = new VentasTableAdapter();
                return ventas;
            }
        }
        private func_ListarProductosVentasTableAdapter FUNC_LISTARPRODUCTOSVENTAS
        {
            get
            {
                if (func_ListarProductosVentasTableAdapter == null)
                    func_ListarProductosVentasTableAdapter = new func_ListarProductosVentasTableAdapter();
                return func_ListarProductosVentasTableAdapter;
            }
        }
        private func_ListarVentaIndividualTableAdapter FUNC_LISTARVENTAINDIVIDUAL
        {
            get
            {
                if (func_ListarVentaIndividualTableAdapter == null)
                    func_ListarVentaIndividualTableAdapter = new func_ListarVentaIndividualTableAdapter();
                return func_ListarVentaIndividualTableAdapter;
            }
        }
        //metodos

        public DataTable ListarVentas()
        {
            return VENTAS.GetDataVenta();
        }
        public DataTable ListarVentasInactivas()
        {
            return VENTAS.GetDataVentaInactiva();
        }
        public DataTable VentaIndividual(int id)
        {
            return FUNC_LISTARVENTAINDIVIDUAL.GetDataVentaIndividual(id);
        }
        public string CrearVenta(int idcliente, Decimal Subtotal, decimal Descuento, decimal Total, string comentario, int metododepago, int empleado, DataTable ventasDataTable)
        {
            string respuesta = "", informacion = "";    
            try
            {
                VENTAS.ProcesoCreacionVenta("C", DateTime.Now, idcliente, Subtotal, Descuento, Total, comentario, metododepago, empleado, ventasDataTable, ref informacion);
                respuesta = informacion;
            }
            catch (Exception error)
            {
                respuesta = "Error: al realizar la venta " + informacion + " " + error.Message;
            }
            return respuesta;
        }///Fin Crear Venta
        public DataTable ListarProductosVentas(int idventa)
        {
            return FUNC_LISTARPRODUCTOSVENTAS.GetDataListadoProductosVentas(idventa);
        }
    }
}
