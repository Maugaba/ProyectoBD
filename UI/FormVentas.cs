using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DAL.DataSetVentas;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;


namespace UI
{
    public partial class FormVentas : Form
    {
        LogicaVentas LogicaVentas = new LogicaVentas();
        LogicaProductos LogicaProductos = new LogicaProductos();
        LogicaClientes LogicaClientes = new LogicaClientes();
        LogicaMetododePago LogicaMetododePago = new LogicaMetododePago();
        DataTable ventasDataTable;
        DataTable datos;
        List<Productosventa> productosventas = new List<Productosventa>();
        Dictionary<int, decimal> productos = new Dictionary<int, decimal>();
        Dictionary<int, int> cliente = new Dictionary<int, int>();
        private int idemployee;
        decimal PrecioSubtotal;
        decimal Descuento;
        decimal PrecioTotal;
        int permisocliente = 0;
        int id = 0;
        public FormVentas(int id)
        {
            InitializeComponent();
            this.idemployee = id;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            comboBoxProducto.DataSource = LogicaProductos.ListarProductosActivos();
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "IdProducto";
            comboBoxCliente.DataSource = LogicaClientes.ListarClientesVentas();
            comboBoxCliente.DisplayMember = "NombreCompleto";
            comboBoxCliente.ValueMember = "IdCliente";
            comboBoxMetodoPago.DataSource = LogicaMetododePago.ListarMetodosActivos();
            comboBoxMetodoPago.DisplayMember = "Nombre";
            comboBoxMetodoPago.ValueMember = "IdMétodoDePago";
            foreach (var item in comboBoxProducto.Items)
            {
                DataRowView row = (DataRowView)item;
                int idProducto = Convert.ToInt32(row["IdProducto"]);
                decimal precio = Convert.ToDecimal(row["Precio_de_Venta"]);
                productos[idProducto] = precio;
            }
            foreach (var item in comboBoxCliente.Items)
            {
                DataRowView row = (DataRowView)item;
                int idCliente = Convert.ToInt32(row["IdCliente"]);
                int descuento = Convert.ToInt32(row["PorcentajeDescuentoEspecial"]);
                cliente[idCliente] = descuento;
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            permisocliente = 1;
            ventasDataTable = new DataTable();
            ventasDataTable.Columns.Add("IdProducto", typeof(int));
            ventasDataTable.Columns.Add("Nombre", typeof(string));
            ventasDataTable.Columns.Add("Cantidad", typeof(int));
            ventasDataTable.Columns.Add("Precio", typeof(string));
            datos = new DataTable();
            datos.Columns.Add("IdProducto", typeof(int));
            datos.Columns.Add("Cantidad", typeof(int));
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            ButtonCrearVenta.Enabled = true;
            buttonNuevo.Enabled = false;
            PrecioSubtotal = 0;
            textBoxDescuento.Text = "% " + (cliente[(int)comboBoxCliente.SelectedValue]).ToString();
        }

        private void ButtonCrearVenta_Click(object sender, EventArgs e)
        {
            if(datos.Rows.Count == 0)
            {
                MessageBox.Show("No se puede crear una venta sin productos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(textBoxComentario.Text == "")
            {
                MessageBox.Show("No se puede crear una venta sin comentario.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = LogicaVentas.CrearVenta((int)comboBoxCliente.SelectedValue, PrecioSubtotal, Descuento, PrecioTotal, textBoxComentario.Text, (int)comboBoxMetodoPago.SelectedValue, idemployee, datos);
            MessageBox.Show(respuesta);
            comboBoxProducto.SelectedIndex = 0;
            numericUpDownCantidad.Value = 1;
            labelPrecioSubTotal.Text = "Subtotal: Q0.00";
            labelPrecioDescuento.Text = "Descuento: Q0.00";
            labelTotal.Text = "Total: Q0.00";
            groupBox1.Enabled = false;
            buttonNuevo.Enabled = true;
            comboBoxCliente.SelectedIndex = 0;
            textBoxDescuento.Text = "";
            comboBoxMetodoPago.SelectedIndex = 0;
            textBoxComentario.Text = "";
            groupBox2.Enabled = false;
            ButtonCrearVenta.Enabled = false;
            dataGridView1.DataSource = LogicaVentas.ListarVentas();
            dataGridView1.Refresh();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Productosventa producto = new Productosventa();
            producto.IdProducto = Convert.ToInt32(comboBoxProducto.SelectedValue);
            producto.Cantidad = Convert.ToInt32(numericUpDownCantidad.Value);
            ventasDataTable.Rows.Add(producto.IdProducto,comboBoxProducto.Text, producto.Cantidad, (productos[(int)comboBoxProducto.SelectedValue] * producto.Cantidad).ToString("C"));
            datos.Rows.Add(producto.IdProducto, producto.Cantidad);
            PrecioSubtotal = Convert.ToDecimal(labelPrecioSubTotal.Text.Substring(11));
            PrecioSubtotal += (productos[(int)comboBoxProducto.SelectedValue] * producto.Cantidad);
            labelPrecioSubTotal.Text = "Subtotal: " + PrecioSubtotal.ToString("C");
            dataGridView1.DataSource = ventasDataTable;
            int descuento = Convert.ToInt32(textBoxDescuento.Text.Substring(2));
            Descuento = PrecioSubtotal * descuento / 100;
            PrecioTotal = PrecioSubtotal - Descuento;
            labelPrecioDescuento.Text = "Descuento: " + Descuento.ToString("C");
            labelTotal.Text = "Total: " + PrecioTotal.ToString("C");
        }

        private void textBoxDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (permisocliente == 1)
            {
                textBoxDescuento.Text = "% " + (cliente[(int)comboBoxCliente.SelectedValue]).ToString();
                int descuento = Convert.ToInt32(textBoxDescuento.Text.Substring(2));
                Descuento = PrecioSubtotal * descuento / 100;
                PrecioTotal = PrecioSubtotal - Descuento;
                labelPrecioDescuento.Text = "Descuento: " + Descuento.ToString("C");
                labelTotal.Text = "Total: " + PrecioTotal.ToString("C");
            }
        }

        private void buttonListarVenta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicaVentas.ListarVentas();
            dataGridView1.Refresh();
        }

        private void ButtonListarVentasInactivas_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicaVentas.ListarVentasInactivas();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                buttonNuevo.Enabled = false;
                buttonAgregar.Enabled = false;
                ButtonAnularVenta.Enabled = true;
                ButtonVisualizarVenta.Enabled = true;
                MessageBox.Show("Has seleccionado la venta con ID: " +id.ToString());
            }

        }

        private void ButtonVisualizarVenta_Click(object sender, EventArgs e)
        {
            ButtonAnularVenta.Enabled = false;
            ButtonVisualizarVenta.Enabled = false;
            FormDescripcionDeVenta formDescripcionDeVenta = new FormDescripcionDeVenta(id);
            formDescripcionDeVenta.Show();
        }
    }
}
