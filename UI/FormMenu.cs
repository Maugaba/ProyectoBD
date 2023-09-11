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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formusuario = new FormUsuario();
            formusuario.Show();
            this.Hide();
        }

        private void ButtonEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formempleados = new FormEmpleados();
            formempleados.Show();
            this.Hide();
        }

        private void ButtonRol_Click(object sender, EventArgs e)
        {
            FormRol formrol = new FormRol();
            formrol.Show();
            this.Hide();
        }

        private void ButtonMetodoDePago_Click(object sender, EventArgs e)
        {
            FormMetodoDePago formMetodoDePago = new FormMetodoDePago();
            formMetodoDePago.Show();
            this.Hide();
        }

        private void ButtonMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas formmarcas = new FormMarcas();
            formmarcas.Show();
            this.Hide();
                
        }

        private void ButtonGarantia_Click(object sender, EventArgs e)
        {
            FormGarantia formGarantia = new FormGarantia();
            formGarantia.Show();
            this.Hide();
        }
    }
}
