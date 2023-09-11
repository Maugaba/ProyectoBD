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
    public partial class FormEmpleados : Form
    {
        int listAoI = 0, id = 0;
        LogicaEmpleado logicaEmpleado = new LogicaEmpleado();
        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {

        }

        private void buttonNuevo_Click_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaEmpleado.ListarEmpleadosInactivos();
            dataGridView1.Refresh();
            listAoI = 0;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaEmpleado.ListarEmpleadosActivos();
            dataGridView1.Refresh();
            listAoI = 1;
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
                MessageBox.Show("El apellido no puede estar vací0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDPI.Text == "")
            {
                MessageBox.Show("El dpi no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDireccion.Text == "")
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTelefono.Text == "")
            {
                MessageBox.Show("El télefono no puede estar vací0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            byte estado;
            if (checkBoxEstado.Checked)
            {
                estado = 1;
            }
            else
            {
                estado = 0;
            }
            respuesta = logicaEmpleado.EditarEmpleado(textBoxNombre.Text, textBoxApellido.Text, dateTimePicker1.Value.ToString(), comboBox1.Text, textBoxDPI.Text, textBoxDireccion.Text, textBoxTelefono.Text, estado, id);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaEmpleado.ListarEmpleadosActivos();
            dataGridView1.Refresh();
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            textBoxDPI.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                checkBoxEstado.Visible = true;
                if (listAoI == 1)
                {
                    checkBoxEstado.Checked = true;
                }
                else
                {
                    checkBoxEstado.Checked = false;
                }
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                textBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxApellido.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                dateTimePicker1.Value = DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                comboBox1.SelectedIndex = comboBox1.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                textBoxDPI.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                textBoxDireccion.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                textBoxTelefono.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
            }
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
                MessageBox.Show("El apellido no puede estar vací0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDPI.Text == "")
            {
                MessageBox.Show("El dpi no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxDireccion.Text == "")
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxTelefono.Text == "")
            {
                MessageBox.Show("El télefono no puede estar vací0.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaEmpleado.NuevoEmpleado(textBoxNombre.Text, textBoxApellido.Text, dateTimePicker1.Value.ToString(), comboBox1.Text, textBoxDPI.Text, textBoxDireccion.Text, textBoxTelefono.Text);
            MessageBox.Show(respuesta);
            textBoxNombre.Text = "";
            textBoxApellido.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            textBoxDPI.Text = "";
            textBoxDireccion.Text = "";
            textBoxTelefono.Text = "";
            dataGridView1.DataSource = logicaEmpleado.ListarEmpleadosActivos();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
        }
    }
}
