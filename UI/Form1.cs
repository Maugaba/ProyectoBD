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

namespace UI
{
    public partial class Form1 : Form
    {
        int a=1, b=1;
        LogicaUsuario logicaUsuario = new LogicaUsuario();

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
            foreach (var item in listaDeObjetos)
            {
                if (item.username == textBoxUsuario.Text)
                {
                    if (item.password == ComprobarContraseña(textBoxContraseña.Text))
                    {
                        MessageBox.Show("Login exitoso.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
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
            // Agrega más propiedades según sea necesario
        }
    }
}
