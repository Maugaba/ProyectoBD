using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DataSetVentasTableAdapters;
using System.Data;

namespace BLL
{
    public class LogicaClientes
    {
        //atributos
        private ClientesTableAdapter clientes = null;
        private ClientesVentasTableAdapter clientesVentas = null;
        //propiedades
        private ClientesTableAdapter CLIENTES
        {
            get
            {
                if (clientes == null)
                    clientes = new ClientesTableAdapter();
                return clientes;
            }
        }
        private ClientesVentasTableAdapter CLIENTESVENTAS
        {
            get
            {
                if (clientesVentas == null)
                    clientesVentas = new ClientesVentasTableAdapter();
                return clientesVentas;
            }
        }
        //metodos
        public DataTable ListarClientesActivos()
        {
            return CLIENTES.GetDataClientes();
        }//fin del metodo ListarEmpleadosActivos

        public DataTable ListarClientesInactivos()
        {
            return CLIENTES.GetDataClientesInactivos();
        }//fin del metodo ListarEmpleadosInactivos

        public DataTable ListarClientesVentas()
        {
            return CLIENTESVENTAS.GetDataClientesVentas();
        }//fin del metodo ListarEmpleadosVentas

        public string NuevoCliente(string nombre, string apellido, string direccion, string telefono, string email, int idtipocliente, string nit)
        {
            int existe;
            existe = Convert.ToInt32(CLIENTES.ScalarQueryExisteCliente(nit));
            if (existe > 0)
                return "Error: el cliente " + nombre + " " + apellido + " ya existe previamente";
            else
            {
                CLIENTES.InsertQueryCliente(nombre, apellido, direccion, telefono, email, idtipocliente, nit);
                return "El cliente " + nombre + " " + apellido + " ha sido agregado exitosamente";
            }
        }//fin del metodo NuevoEmpleado

        public string EditarCliente (string nombre, string apellido, string direccion, string telefono, string email, int idtipocliente, string nit, byte state, int id)
        {
            int existe;
            existe = Convert.ToInt32(CLIENTES.ScalarQueryExisteCliente(nit));
            if (existe > 1)
                return "Error: el cliente " + nombre + " " + apellido + " ya existe previamente";
            else
            {
                CLIENTES.UpdateQueryCliente(nombre, apellido, direccion, email, telefono,  idtipocliente, nit, state, id);
                return "El cliente " + nombre + " " + apellido + " ha sido editado exitosamente";
            }
        }//fin del metodo EditarEmpleado
    }
}
