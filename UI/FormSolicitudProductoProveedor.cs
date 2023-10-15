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
            Estado.Visible = false;
            comboBoxEstado.Visible = false;
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

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxCantidad.Text == "")
            {
                MessageBox.Show("La cantidad solicitada no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (comboBoxEstado.Text == "")
            {
                MessageBox.Show("El estado no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaSolicitudProductoProveedor.EditarSolicitud((int)comboBoxProducto.SelectedValue, (int)comboBoxProveedor.SelectedValue, Convert.ToInt32(textBoxCantidad.Text), (int)comboBoxEstado.SelectedIndex,id);
            MessageBox.Show(respuesta);
            comboBoxProducto.SelectedIndex = 0;
            comboBoxProveedor.SelectedIndex = 0;
            textBoxCantidad.Text = "";
            comboBoxEstado.SelectedIndex = 0;
            dataGridView1.DataSource = logicaSolicitudProductoProveedor.ListarSolicitudesActivas();
            dataGridView1.Refresh();
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            comboBoxEstado.SelectedIndex = 0;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaSolicitudProductoProveedor.ListarSolicitudesActivas();
            dataGridView1.Refresh();
            buttonEditar.Enabled = true;
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaSolicitudProductoProveedor.ListarSolicitudesInactivas();
            dataGridView1.Refresh();
            buttonEditar.Enabled = true;
        }

        private void rjButtonListarCompletados_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaSolicitudProductoProveedor.ListarSolicitudesCompletadas();
            dataGridView1.Refresh();
            buttonEditar.Enabled = false;
            dataGridView1.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                comboBoxProducto.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[1].Value.GetHashCode();
                comboBoxProveedor.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[2].Value.GetHashCode();
                textBoxCantidad.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxEstado.SelectedIndex = dataGridView1.Rows[e.RowIndex].Cells[4].Value.GetHashCode();
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
                comboBoxEstado.Visible = true;
                Estado.Visible = true;
            }
        }
    }
}
