using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UI
{
    public partial class Form1 : Form
    {
        LogicaUsuario logicaUsuario = new LogicaUsuario();
        int a = 0;
        public Form1()
        {
            InitializeComponent();
            textBoxUsuario.GotFocus += textBox1_GotFocus;
            textBoxUsuario.LostFocus += textBox1_LostFocus;
            textBoxContraseña.GotFocus += textBox2_GotFocus;
            textBoxContraseña.LostFocus += textBox2_LostFocus;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Ocultar.BringToFront();
            textBoxContraseña.UseSystemPasswordChar = false;
        }

        private void Ocultar_Click(object sender, EventArgs e)
        {
            pictureBox4.BringToFront();
            textBoxContraseña.UseSystemPasswordChar = true;
        }

        private void textBox1_GotFocus(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text == "Usuario")
            {
                textBoxUsuario.Text = "";
                textBoxUsuario.ForeColor = SystemColors.WindowText; 
            }
        }
        private void textBox1_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                textBoxUsuario.Text = "Usuario";
                textBoxUsuario.ForeColor = SystemColors.GrayText; 
            }
        }
        private void textBox2_GotFocus(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text == "Contraseña")
            {
                textBoxContraseña.Text = "";
                textBoxContraseña.ForeColor = SystemColors.WindowText;
            }
        }
        private void textBox2_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                textBoxContraseña.Text = "Contraseña";
                textBoxContraseña.ForeColor = SystemColors.GrayText;
            }
        }

        private void ButtonIniciarSesion_Click(object sender, EventArgs e)
        {
            List<MyObject> listaDeObjetos = logicaUsuario.Login().AsEnumerable()
            .Select(row => new MyObject
            {
                Id = row.Field<int>("IdUsuario"),
                username = row.Field<string>("Usuario"),
                password = row.Field<string>("Contraseña"),
                rol = row.Field<int>("IdRol"),
            })
            .ToList();
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
            int error = 0;
            foreach (var item in listaDeObjetos)
            {
                if (item.username == textBoxUsuario.Text)
                {
                    error = 0;
                    if (item.password == ComprobarContraseña(textBoxContraseña.Text))
                    {
                        FormMenu form = new FormMenu(item.rol, item.Id);
                        form.Show();
                        this.Hide();
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    error = 1;
                }
            }
            if (error == 1)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        static string ComprobarContraseña(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(bytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2")); // Convierte cada byte a su representación hexadecimal
                }

                return stringBuilder.ToString();
            }
        }

        class MyObject
        {
            public int Id { get; set; }
            public string username { get; set; }
            public string password { get; set; }
            public int rol { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            if (a == 0)
            {
                textBoxContraseña.UseSystemPasswordChar = true;
                a=1;
            }
         
        }
    }
}
