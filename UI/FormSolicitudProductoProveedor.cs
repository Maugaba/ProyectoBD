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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class FormSolicitudProductoProveedor : Form
    {
        LogicaSolocitud logicaSolicitudProductoProveedor = new LogicaSolocitud();
        LogicaProductos logicaProductos = new LogicaProductos();
        LogicaProveedores logicaProveedores = new LogicaProveedores();
        int id = 0;
        public FormSolicitudProductoProveedor()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                MessageBox.Show("La cantidad solicitada no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaSolicitudProductoProveedor.NuevaSolicitud((int)comboBoxProducto.SelectedValue, (int)comboBoxProveedor.SelectedValue, Convert.ToInt32(textBoxCantidad.Text));
            MessageBox.Show(respuesta);
            comboBoxProducto.SelectedIndex = 0;
            comboBoxProveedor.SelectedIndex = 0;
            textBoxCantidad.Text = "";
            comboBoxEstado.SelectedIndex = 0;
            dataGridView1.DataSource = logicaSolicitudProductoProveedor.ListarSolicitudesActivas();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void FormSolicitudProductoProveedor_Load(object sender, EventArgs e)
        {
            comboBoxProducto.DataSource = logicaProductos.ListarProductosActivos();
            comboBoxProducto.DisplayMember = "Nombre";
            comboBoxProducto.ValueMember = "IdProducto";
            comboBoxProveedor.DataSource = logicaProveedores.ListarProveedoresActivos();
            comboBoxProveedor.DisplayMember = "Nombre";
            comboBoxProveedor.ValueMember = "IdProveedor";
        }
    }
}
