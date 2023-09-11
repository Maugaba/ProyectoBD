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
    public partial class FormGarantia : Form
    {
        int id = 0;
        LogicaGarantia logicaGarantia = new LogicaGarantia();
        public FormGarantia()
        {
            InitializeComponent();
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            buttonNuevo.Enabled = false;
            buttonGuardar.Enabled = true;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (textBoxGarantia.Text == "")
            {
                MessageBox.Show("El tiempó de la garantia no puede estar vacia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaGarantia.NuevaGarantia(Convert.ToInt32(textBoxGarantia.Text));
            MessageBox.Show(respuesta);
            textBoxGarantia.Text = "";
            dataGridView1.DataSource = logicaGarantia.ListarGarantiasActivas();
            dataGridView1.Refresh();
            buttonGuardar.Enabled = false;
            buttonNuevo.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (textBoxGarantia.Text == "")
            {
                MessageBox.Show("El tiempó de la garantia no puede estar vacia.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string respuesta = "";
            respuesta = logicaGarantia.ModificarGarantia(Convert.ToInt32(textBoxGarantia.Text), Convert.ToByte(checkBoxEstado.CheckState), id);
            MessageBox.Show(respuesta);
            dataGridView1.DataSource = logicaGarantia.ListarGarantiasActivas();
            dataGridView1.Refresh();
            textBoxGarantia.Text = "";
            buttonEditar.Enabled = false;
            buttonNuevo.Enabled = true;
            checkBoxEstado.Visible = false;
            groupBox1.Enabled = false;
        }

        private void buttonListarActivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaGarantia.ListarGarantiasActivas();
            dataGridView1.Refresh();
        }

        private void buttonListarInactivos_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = logicaGarantia.ListarGarantiasInactivas();
            dataGridView1.Refresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                checkBoxEstado.Visible = true;
                id = dataGridView1.Rows[e.RowIndex].Cells[0].Value.GetHashCode();
                textBoxGarantia.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                checkBoxEstado.Checked = Convert.ToBoolean(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                buttonEditar.Enabled = true;
                buttonNuevo.Enabled = false;
                groupBox1.Enabled = true;
                buttonGuardar.Enabled = false;
            }
        }
    }
}
