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
        List<Productosventa> productosventas = new List<Productosventa>();
        //atributos
        private VentasTableAdapter ventas = null;
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
        //metodos
        public string CrearVenta()
        {
            string respuesta = "", informacion = "";
            productosventas.Add(new Productosventa { IdProducto = 4, Cantidad = 1 });
            productosventas.Add(new Productosventa { IdProducto = 4, Cantidad = 2 });
            DataTable ventasDataTable = new DataTable();
            ventasDataTable.Columns.Add("IdProducto", typeof(int));
            ventasDataTable.Columns.Add("Cantidad", typeof(int));

            // Llenar la DataTable con los datos de productosventas
            foreach (var productoVenta in productosventas)
            {
                ventasDataTable.Rows.Add(productoVenta.IdProducto, productoVenta.Cantidad);
            }
            
            try
            {

                VENTAS.ProcesoCreacionVenta("34", "A", DateTime.Now, 1, Convert.ToDecimal(20), Convert.ToDecimal(0), Convert.ToDecimal(20), "venta1", 1, 1, ventasDataTable, ref informacion);
                respuesta = informacion;
            }
            catch (Exception error)
            {
                respuesta = "Error: al realizar la venta " + informacion + " " + error.Message;
            }
            return respuesta;
        }//Fin NuevoAutorConEscribe
    }
}
