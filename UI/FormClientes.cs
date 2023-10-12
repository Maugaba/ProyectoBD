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
    public partial class FormClientes : Form
    {
        LogicaClientes logicaClientes = new LogicaClientes();
        LogicaTiposClientes logicaTiposClientes = new LogicaTiposClientes();
        int id = 0;
        public FormClientes()
        {
            InitializeComponent();
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = logicaTiposClientes.ListarTiposdeclientes();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "IdTipoCliente";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxApellido.Text == "")
            {
                MessageBox.Show("El apellido no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxNit.Text == "")
            {
                MessageBox.Show("El nit no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("El email no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTelefono.Text == "")
            {
                MessageBox.Show("El telefono no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDireccion.Text == "")
            {
                MessageBox.Show("La direccion no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaClientes.NuevoCliente(textBoxNombre.Text, textBoxApellido.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text, (int)comboBox1.SelectedValue, textBoxNit.Text);
            MessageBox.Show(respuesta);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            textBoxNit.Text = "";
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = logicaClientes.ListarClientesActivos();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxApellido.Text == "")
            {
                MessageBox.Show("El apellido no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxNit.Text == "")
            {
                MessageBox.Show("El nit no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxEmail.Text == "")
            {
                MessageBox.Show("El email no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTelefono.Text == "")
            {
                MessageBox.Show("El telefono no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDireccion.Text == "")
            {
                MessageBox.Show("La direccion no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaClientes.EditarCliente(textBoxNombre.Text, textBoxApellido.Text, textBoxDireccion.Text, textBoxTelefono.Text, textBoxEmail.Text, (int)comboBox1.SelectedValue, textBoxNit.Text, Convert.ToByte(checkBoxEstado.CheckState),id);
            MessageBox.Show(respuesta);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            textBoxEmail.Text = "";
            textBoxNit.Text = "";
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataSource = logicaClientes.ListarClientesActivos();
            dataGridView1.Refresh();
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaClientes.ListarClientesActivos();
            dataGridView1.Refresh();
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaClientes.ListarClientesInactivos();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                checkBoxEstado.Visible = true;
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                textBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxApellido.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBoxDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                textBoxTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                textBoxEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                comboBox1.SelectedValue = dataGridView1.Rows[e.RowIndex].Cells[6].Value.GetHashCode();
                textBoxNit.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[8].Value);
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
            }
        }
    }
}
