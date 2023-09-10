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
    public partial class Form1 : Form
    {
        int a=1, b=1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ocultar.BringToFront();
            textBoxContraseña.PasswordChar = '\0';
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            textBoxContraseña.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {
                textBoxUsuario.Text = "";
                a=0;
            }
        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (b == 1)
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.PasswordChar = '*';
                b = 0;
            }
        }
    }
}
