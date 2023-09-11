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
    public partial class FormMetodoDePago : Form
    {
        int id = 0;
        LogicaMetododePago logicaMetododePago = new LogicaMetododePago();
        public FormMetodoDePago()
        {
            InitializeComponent();
        }

        private void FormMetodoDePago_Load(object sender, EventArgs e)
        {

        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonNuevo.Enabled = false;
            buttonGuardar.Enabled = true;
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
            string respuesta = "";
            respuesta = logicaMetododePago.NuevoMetodo(textBoxNombre.Text, textBoxDescripcion.Text);
            MessageBox.Show(respuesta);
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            dataGridView1.DataSource = logicaMetododePago.ListarMetodosActivos();
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
            if (textBoxDescripcion.Text == "")
            {
                MessageBox.Show("La descripcion no puede estar vacía.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaMetododePago.EditarMetodo(textBoxNombre.Text, textBoxDescripcion.Text, Convert.ToByte(checkBoxEstado.CheckState), id);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaMetododePago.ListarMetodosActivos();
            dataGridView1.Refresh();
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaMetododePago.ListarMetodosActivos();
            dataGridView1.Refresh();

        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaMetododePago.ListarMetodosInactivos();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                checkBoxEstado.Visible = true;
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                textBoxNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBoxDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
            }
        }
    }
}
