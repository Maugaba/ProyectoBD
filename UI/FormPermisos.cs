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
    public partial class FormPermisos : Form
    {
        LogicaRol LogicaRol = new LogicaRol();
        private int id;
        private byte accion;
        List<MyObject> listaDeObjetos;
        public FormPermisos(int id, byte accion)
        {
            InitializeComponent();
            this.id = id; 
            this.accion = accion;
        }

        private void FormPermisos_Load(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                buttonGuardar.Text = "Guardar";
            }
            if (accion == 1)
            {
                buttonGuardar.Text = "Editar";
                listaDeObjetos = LogicaRol.ListarPermisos(id).AsEnumerable()
                .Select(row => new MyObject
                {
                    Id = row.Field<int>("IdRolesPermisos"),
                    rol = row.Field<int>("IdRol"),
                    permiso = row.Field<int>("IdPermiso"),
                    estado = row.Field<byte>("Estado"),
                })
                .ToList();
                ToggleButtonUsuarios.Checked = Convert.ToBoolean(listaDeObjetos[0].estado);
                ToggleButtonEmpleados.Checked = Convert.ToBoolean(listaDeObjetos[1].estado);
                ToggleButtonClientes.Checked = Convert.ToBoolean(listaDeObjetos[2].estado);
                ToggleButtonProveedores.Checked = Convert.ToBoolean(listaDeObjetos[3].estado);
                ToggleButtonProductos.Checked = Convert.ToBoolean(listaDeObjetos[4].estado);
                ToggleButtonCategoriaDeProductos.Checked = Convert.ToBoolean(listaDeObjetos[5].estado);
                ToggleButtonMarcas.Checked = Convert.ToBoolean(listaDeObjetos[6].estado);
                rjToggleButtonReportes.Checked = Convert.ToBoolean(listaDeObjetos[7].estado);
                rjToggleButtonRoles.Checked = Convert.ToBoolean(listaDeObjetos[8].estado);
                rjToggleGarantias.Checked = Convert.ToBoolean(listaDeObjetos[9].estado);
                rjToggleMetodos.Checked = Convert.ToBoolean(listaDeObjetos[10].estado);
                rjToggleButtonTiposClientes.Checked = Convert.ToBoolean(listaDeObjetos[11].estado);
                rjToggleVentas.Checked = Convert.ToBoolean(listaDeObjetos[12].estado);
                rjToggleButtonSolicitud.Checked = Convert.ToBoolean(listaDeObjetos[13].estado);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rjToggleButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (accion == 0)
            {
                Guardar();
            }
            if (accion == 1)
            {
                Editar();
            }
            

        }
        private void Guardar()
        {
            LogicaRol.NuevoPermiso(id, 1, Convert.ToByte(ToggleButtonUsuarios.Checked));
            LogicaRol.NuevoPermiso(id, 2, Convert.ToByte(ToggleButtonEmpleados.Checked));
            LogicaRol.NuevoPermiso(id, 3, Convert.ToByte(ToggleButtonClientes.Checked));
            LogicaRol.NuevoPermiso(id, 4, Convert.ToByte(ToggleButtonProveedores.Checked));
            LogicaRol.NuevoPermiso(id, 5, Convert.ToByte(ToggleButtonProductos.Checked));
            LogicaRol.NuevoPermiso(id, 6, Convert.ToByte(ToggleButtonCategoriaDeProductos.Checked));
            LogicaRol.NuevoPermiso(id, 7, Convert.ToByte(ToggleButtonMarcas.Checked));
            LogicaRol.NuevoPermiso(id, 8, Convert.ToByte(rjToggleButtonReportes.Checked));
            LogicaRol.NuevoPermiso(id, 9, Convert.ToByte(rjToggleButtonRoles.Checked));
            LogicaRol.NuevoPermiso(id, 10, Convert.ToByte(rjToggleGarantias.Checked));
            LogicaRol.NuevoPermiso(id, 11, Convert.ToByte(rjToggleMetodos.Checked));
            LogicaRol.NuevoPermiso(id, 12, Convert.ToByte(rjToggleButtonTiposClientes.Checked));
            LogicaRol.NuevoPermiso(id, 13, Convert.ToByte(rjToggleVentas.Checked));
            LogicaRol.NuevoPermiso(id, 14, Convert.ToByte(rjToggleButtonSolicitud.Checked));
            MessageBox.Show("Se han guardado los permisos correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Editar()
        {
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonUsuarios.Checked), listaDeObjetos[0].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonEmpleados.Checked), listaDeObjetos[1].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonClientes.Checked), listaDeObjetos[2].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonProveedores.Checked), listaDeObjetos[3].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonProductos.Checked), listaDeObjetos[4].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonCategoriaDeProductos.Checked), listaDeObjetos[5].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(ToggleButtonMarcas.Checked), listaDeObjetos[6].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleButtonReportes.Checked), listaDeObjetos[7].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleButtonRoles.Checked), listaDeObjetos[8].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleGarantias.Checked), listaDeObjetos[9].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleMetodos.Checked), listaDeObjetos[10].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleButtonTiposClientes.Checked), listaDeObjetos[11].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleVentas.Checked), listaDeObjetos[12].Id);
            LogicaRol.EditarPermiso(Convert.ToByte(rjToggleButtonSolicitud.Checked), listaDeObjetos[13].Id);
            MessageBox.Show("Se han editado los permisos correctamente.", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        class MyObject
        {
            public int Id { get; set; }
            public int rol { get; set; }
            public int permiso { get; set; }
            public byte estado { get; set; }
        }
    }
}
