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
    public partial class FormTipoDeCliente : Form
    {
        int id = 0;
        LogicaTiposClientes logicaTipoDeCliente = new LogicaTiposClientes();
        public FormTipoDeCliente()
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
            if (textBoxdescuento.Text == "")
            {
                MessageBox.Show("El descuento puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaTipoDeCliente.Nuevotipodeusuario(textBoxNombre.Text, textBoxDescripcion.Text, Convert.ToInt32(textBoxdescuento.Text));
            MessageBox.Show(respuesta);
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            textBoxdescuento.Text = "";
            dataGridView1.DataSource = logicaTipoDeCliente.ListarTiposdeclientes();
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
            if (textBoxdescuento.Text == "")
            {
                MessageBox.Show("El descuento puede estar vacío.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaTipoDeCliente.EditarTipodeusuario(textBoxNombre.Text, textBoxDescripcion.Text, Convert.ToInt32(textBoxdescuento.Text), Convert.ToByte(checkBoxEstado.CheckState), id);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaTipoDeCliente.ListarTiposdeclientes();
            dataGridView1.Refresh();
            textBoxNombre.Text = "";
            textBoxDescripcion.Text = "";
            textBoxdescuento.Text = "";
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaTipoDeCliente.ListarTiposdeclientes();
            dataGridView1.Refresh();
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaTipoDeCliente.ListarTiposdeClientesInactivos();
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
                textBoxdescuento.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
            }
        }
    }
}
