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

namespace UI
{
    public partial class FormProductos : Form
    {
        LogicaProductos logicaProductos = new LogicaProductos();
        LogicaMarca logicaMarca = new LogicaMarca();
        LogicaGarantia LogicaGarantia = new LogicaGarantia();
        LogicaCategoria logicaCategoria = new LogicaCategoria();
        LogicaProveedores logicaProveedores = new LogicaProveedores();
        int id = 0;
        public FormProductos()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {
            comboBoxMarca.DataSource = logicaMarca.ListarMarcasActivas();
            comboBoxMarca.DisplayMember = "Nombre";
            comboBoxMarca.ValueMember = "IdMarca";
            comboBoxGarantia.DataSource = LogicaGarantia.ListarGarantiasActivas();
            comboBoxGarantia.DisplayMember = "TiempoDeGarantíaEnDias";
            comboBoxGarantia.ValueMember = "IdGarantía";
            comboBoxCategoria.DataSource = logicaCategoria.ListarCategoriasActivas();
            comboBoxCategoria.DisplayMember = "Nombre";
            comboBoxCategoria.ValueMember = "IdCategoría";
            comboBoxProveedor.DataSource = logicaProveedores.ListarProveedoresActivos();
            comboBoxProveedor.DisplayMember = "Nombre";
            comboBoxProveedor.ValueMember = "IdProveedor";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxStock.Text == "")
            {
                MessageBox.Show("El stock no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxPrecioVenta.Text == "")
            {
                MessageBox.Show("El precio de venta no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxModelo.Text == "")
            {
                MessageBox.Show("El modelo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxExistencia.Text == "")
            {
                MessageBox.Show("La existencia mínima no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaProductos.NuevoProducto(textBoxNombre.Text, textBoxDescripcion.Text, Convert.ToDecimal(textBoxPrecioVenta.Text),(int)comboBoxMarca.SelectedValue, textBoxModelo.Text, Convert.ToInt32(textBoxStock.Text),  Convert.ToInt32(textBoxExistencia.Text), (int)comboBoxGarantia.SelectedValue, (int)comboBoxCategoria.SelectedValue, dateTimePicker1.Value.ToString(), (int)comboBoxProveedor.SelectedValue);
            MessageBox.Show(respuesta);
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxProveedor.SelectedIndex = 0;
            comboBoxGarantia.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecioVenta.Text = "";
            textBoxModelo.Text = "";
            textBoxStock.Text = "";
            textBoxExistencia.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DataSource = logicaProductos.ListarProductosActivos();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxStock.Text == "")
            {
                MessageBox.Show("El stock no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxPrecioVenta.Text == "")
            {
                MessageBox.Show("El precio de venta no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxModelo.Text == "")
            {
                MessageBox.Show("El modelo no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxExistencia.Text == "")
            {
                MessageBox.Show("La existencia mínima no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaProductos.EditarProducto(textBoxNombre.Text, textBoxDescripcion.Text, Convert.ToDecimal(textBoxPrecioVenta.Text), (int)comboBoxMarca.SelectedValue, textBoxModelo.Text, Convert.ToInt32(textBoxStock.Text), Convert.ToInt32(textBoxExistencia.Text), (int)comboBoxGarantia.SelectedValue, (int)comboBoxCategoria.SelectedValue, dateTimePicker1.Value.ToString(), (int)comboBoxProveedor.SelectedValue, Convert.ToByte(checkBoxEstado.CheckState),id);
            MessageBox.Show(respuesta);
            comboBoxCategoria.SelectedIndex = 0;
            comboBoxProveedor.SelectedIndex = 0;
            comboBoxGarantia.SelectedIndex = 0;
            comboBoxMarca.SelectedIndex = 0;
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            textBoxPrecioVenta.Text = "";
            textBoxModelo.Text = "";
            textBoxStock.Text = "";
            textBoxExistencia.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            dataGridView1.DataSource = logicaProductos.ListarProductosActivos();
            dataGridView1.Refresh();
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaProductos.ListarProductosActivos();
            dataGridView1.Refresh();
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaProductos.ListarProductosInactivos();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            groupBox1.Enabled = true;
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                textBoxDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxPrecioVenta.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBoxMarca.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[4].Value.GetHashCode();
                textBoxModelo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxStock.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxExistencia.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                comboBoxGarantia.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[8].Value.GetHashCode();
                comboBoxCategoria.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[9].Value.GetHashCode();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                comboBoxProveedor.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[11].Value.GetHashCode();
                checkBoxEstado.Visible = true;
                checkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
            }
            buttonEditar.Enabled = true;
        }
    }
}
