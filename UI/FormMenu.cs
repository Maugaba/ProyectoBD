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
using System.Xml.Linq;

namespace UI
{
    public partial class FormMenu : Form
    {
        LogicaRol LogicaRol = new LogicaRol();
        private int id;
        public FormMenu(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void buttonUsuario_Click(object sender, EventArgs e)
        {
            FormUsuario formusuario = new FormUsuario();
            formusuario.Show();
        }

        private void ButtonEmpleados_Click(object sender, EventArgs e)
        {
            FormEmpleados formempleados = new FormEmpleados();
            formempleados.Show();
        }

        private void ButtonRol_Click(object sender, EventArgs e)
        {
            FormRol formrol = new FormRol();
            formrol.Show();
        }

        private void ButtonMetodoDePago_Click(object sender, EventArgs e)
        {
            FormMetodoDePago formMetodoDePago = new FormMetodoDePago();
            formMetodoDePago.Show();

        }

        private void ButtonMarcas_Click(object sender, EventArgs e)
        {
            FormMarcas formmarcas = new FormMarcas();
            formmarcas.Show();
        }

        private void ButtonGarantia_Click(object sender, EventArgs e)
        {
            FormGarantia formGarantia = new FormGarantia();
            formGarantia.Show();
        }

        private void rjButtonCloseSession_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }

        private void ButtonAsignacionPermisos_Click(object sender, EventArgs e)
        {

        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            List<MyObject> listaDeObjetos = LogicaRol.ListarPermisos(id).AsEnumerable()
            .Select(row => new MyObject
            {
                Id = row.Field<int>("IdRolesPermisos"),
                rol = row.Field<int>("IdRol"),
                permiso = row.Field<int>("IdPermiso"),
                estado = row.Field<byte>("Estado"),
            })
            .ToList();
            buttonUsuario.Enabled = Convert.ToBoolean(listaDeObjetos[0].estado);
            ButtonEmpleados.Enabled = Convert.ToBoolean(listaDeObjetos[1].estado);
            ButtonClientes.Enabled = Convert.ToBoolean(listaDeObjetos[2].estado);
            ButtonProveedores.Enabled = Convert.ToBoolean(listaDeObjetos[3].estado);
            rjButtonProductos.Enabled = Convert.ToBoolean(listaDeObjetos[4].estado);
            ButtonCategoriaProducto.Enabled = Convert.ToBoolean(listaDeObjetos[5].estado);
            ButtonMarcas.Enabled = Convert.ToBoolean(listaDeObjetos[6].estado);
            ButtonFacturas.Enabled = Convert.ToBoolean(listaDeObjetos[7].estado);
            ButtonRol.Enabled = Convert.ToBoolean(listaDeObjetos[8].estado);
            ButtonGarantia.Enabled = Convert.ToBoolean(listaDeObjetos[9].estado);
            ButtonMetodoDePago.Enabled = Convert.ToBoolean(listaDeObjetos[10].estado);
            ButtonTiposDeClientes.Enabled = Convert.ToBoolean(listaDeObjetos[11].estado);
            ButtonVentas.Enabled = Convert.ToBoolean(listaDeObjetos[12].estado);
        }

        private void ButtonTiposDeClientes_Click(object sender, EventArgs e)
        {
            FormTipoDeCliente formtipodeusuario = new FormTipoDeCliente();
            formtipodeusuario.Show();
        }

        private void ButtonFacturas_Click(object sender, EventArgs e)
        {

        }

        private void ButtonCategoriaProducto_Click(object sender, EventArgs e)
        {
            FormCategorias formcateg = new FormCategorias();
            formcateg.Show();
        }

        private void ButtonProveedores_Click(object sender, EventArgs e)
        {
            FormProveedores formproveedores = new FormProveedores();
            formproveedores.Show();
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            FormClientes formcliente = new FormClientes();
            formcliente.Show();
        }

        class MyObject
        {
            public int Id { get; set; }
            public int rol { get; set; }
            public int permiso { get; set; }
            public byte estado { get; set; }
        }

        private void rjButtonProductos_Click(object sender, EventArgs e)
        {
            FormProductos formproductos = new FormProductos();
            formproductos.Show();
        }

        private void rjButtonSolicitudPP_Click(object sender, EventArgs e)
        {
            FormSolicitudProductoProveedor formsolicitudpp = new FormSolicitudProductoProveedor();
            formsolicitudpp.Show();
        }

        private void ButtonVentas_Click(object sender, EventArgs e)
        {
            FormVentas formventa = new FormVentas();
            formventa.Show();
        }
    }
}
