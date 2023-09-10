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
    public partial class FormUsuario : Form
    {
        int listAoI = 0, id = 0;
        LogicaUsuario logicaUsuario = new LogicaUsuario();
        LogicaRol logicaRol = new LogicaRol();
        LogicaEmpleado logicaEmpleado = new LogicaEmpleado();
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void FormUsuario_Load(object sender, EventArgs e)
        {
            comboBoxEmpleado.DataSource = logicaEmpleado.ListarEmpleadosActivos();
            comboBoxEmpleado.DisplayMember = "NombreCompleto";
            comboBoxEmpleado.ValueMember = "IdEmpleado";
            comboBoxRol.DataSource = logicaRol.ListarRolesActivos();
            comboBoxRol.DisplayMember = "Nombre";
            comboBoxRol.ValueMember = "IdRol";
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonGuardar.Enabled = true;
            buttonNuevo.Enabled = false;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("El usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (textBoxContraseña.Text == "")
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaUsuario.NuevoUsuario(textBoxUsuario.Text, textBoxContraseña.Text, (int)comboBoxRol.SelectedValue, (int)comboBoxEmpleado.SelectedValue);
            MessageBox.Show(respuesta);
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";
            comboBoxEmpleado.SelectedIndex = 0;
            comboBoxRol.SelectedIndex = 0;
            dataGridView1.DataSource = logicaUsuario.ListarUsuariosActivos();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaUsuario.ListarUsuariosActivos();
            dataGridView1.Refresh();
            listAoI = 1;
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaUsuario.ListarUsuariosInactivos();
            dataGridView1.Refresh();
            listAoI = 0;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "")
            {
                MessageBox.Show("El usuario no puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            respuesta = logicaUsuario.EditarUsuario(textBoxUsuario.Text, (int)comboBoxRol.SelectedValue, estado, id, (int)comboBoxEmpleado.SelectedValue);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaUsuario.ListarUsuariosActivos();
            dataGridView1.Refresh();
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";
            comboBoxEmpleado.SelectedIndex = 0;
            comboBoxRol.SelectedIndex = 0;
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "")
            {
                MessageBox.Show("La contraseña no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaUsuario.CambiarContraseña(textBoxContraseña.Text, id);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaUsuario.ListarUsuariosActivos();
            dataGridView1.Refresh();
            textBoxUsuario.Text = "";
            textBoxContraseña.Text = "";
            comboBoxEmpleado.SelectedIndex = 0;
            comboBoxRol.SelectedIndex = 0;
            buttonEditar.Enabled = false;
            button1.Enabled = false;
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
                textBoxUsuario.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBoxRol.SelectedIndex = comboBoxRol.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
                comboBoxEmpleado.SelectedIndex = comboBoxEmpleado.FindStringExact(dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
                button1.Enabled = true;
            }
        }
    }
}
