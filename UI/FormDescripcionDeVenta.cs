using BLL;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.tool.xml;

namespace UI
{
    public partial class FormDescripcionDeVenta : Form
    {
        private int id;
        LogicaVentas LogicaVentas = new LogicaVentas();
        private Venta InfoVenta;
        public FormDescripcionDeVenta(int id)
        {
            InitializeComponent();
            this.id = id;
        }
        class Venta
        {
            public string IdVenta { get; set; }
            public DateTime Fecha { get; set; }
            public string NombreCliente { get; set; }
            public string Nit { get; set; }
            public string Direccion { get; set; }
            public decimal Subtotal { get; set; }
            public decimal Descuento { get; set; }
            public decimal Total { get; set; }
            public string Comentario { get; set; }
            public string NombreMetodoDePago { get; set; }
            public string NombreEmpleado { get; set; }
            public string LetradeSerie { get; set; }
            public string NúmeroCorrelativo { get; set; }
        }
        private void FormDescripcionDeVenta_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LogicaVentas.ListarProductosVentas(id);
            dataGridView1.Refresh();

            InfoVenta = LogicaVentas.VentaIndividual(id).AsEnumerable().Select(m => new Venta()
            {
                IdVenta = m.Field<int>("IdVenta").ToString("D3"),
                Fecha = m.Field<DateTime>("Fecha"),
                NombreCliente = m.Field<string>("NombreCliente"),
                Nit = m.Field<string>("Nit"),
                Direccion = m.Field<string>("Dirección"),
                Subtotal = m.Field<decimal>("Subtotal"),
                Descuento = m.Field<decimal>("Descuento"),
                Total = m.Field<decimal>("Total"),
                Comentario = m.Field<string>("Comentario"),
                NombreMetodoDePago = m.Field<string>("NombreMetodoDePago"),
                NombreEmpleado = m.Field<string>("NombreEmpleado"),
                LetradeSerie = m.Field<string>("LetradeSerie"),
                NúmeroCorrelativo = m.Field<int>("NúmeroCorrelativo").ToString("D6")
            }).SingleOrDefault();

            labelIdFactura.Text = InfoVenta.IdVenta;
            labelFecha.Text = InfoVenta.Fecha.ToString("dd/MM/yyyy");
            labelCliente.Text = InfoVenta.NombreCliente;
            labelNIT.Text = InfoVenta.Nit;
            labelSubtotal.Text = InfoVenta.Subtotal.ToString("F2");
            labelDescuento.Text = InfoVenta.Descuento.ToString("F2");
            labelTotal.Text = InfoVenta.Total.ToString("F2");
            labelComentario.Text = InfoVenta.Comentario;
            labelMetododePago.Text = InfoVenta.NombreMetodoDePago;
            labelEmpleado.Text = InfoVenta.NombreEmpleado;
            labelLetra.Text = InfoVenta.LetradeSerie;
            labelCorrelativo.Text = InfoVenta.NúmeroCorrelativo.ToString();
        }

        private void ButtonVisualizarVenta_Click(object sender, EventArgs e)
        {
            string exePath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string facturaFolderPath = System.IO.Path.Combine(exePath, "Facturas");

            if (!Directory.Exists(facturaFolderPath))
            {
                Directory.CreateDirectory(facturaFolderPath);
            }
            string formattedDate = DateTime.Now.ToString("TechSavvy_dd-MM-yyyy_HH-mm-ss");
            string pdfPath = Path.Combine(facturaFolderPath, $"{formattedDate}.pdf");

            string PaginaHTML_Texto = Properties.Resources.Plantilla.ToString();
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NOFACTURA", labelIdFactura.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SERIE", labelLetra.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CORRELATIVO", labelCorrelativo.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FECHA", labelFecha.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@CLIENTE", labelCliente.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@NIT", labelNIT.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DIRECCION", InfoVenta.Direccion);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@SUBTOTAL", InfoVenta.Subtotal.ToString("C"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@DESCUENTO", InfoVenta.Descuento.ToString("C"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TOTAL", InfoVenta.Total.ToString("C"));
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@TIPODEPAGO", labelMetododePago.Text);
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@EMPLEADO", labelEmpleado.Text);

            string filas = string.Empty;
            decimal total = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                filas += "<tr>";
                filas += "<td>" + row.Cells["Nombre"].Value + "</td>";
                filas += "<td>" + row.Cells["PrecioUnitario"].Value + "</td>";
                filas += "<td>" + row.Cells["Cantidad"].Value + "</td>";
                filas += "<td>" + row.Cells["Importe"].Value + "</td>";
                filas += "</tr>";
            }
            PaginaHTML_Texto = PaginaHTML_Texto.Replace("@FILAS", filas);
            using (FileStream stream = new FileStream(pdfPath, FileMode.Create))
            {
                //Creamos un nuevo documento y lo definimos como PDF
                Document pdfDoc = new Document(PageSize.A4, 25, 25, 25, 25);

                PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(new Phrase(""));

                //Agregamos la imagen del banner al documento
                iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(Properties.Resources.TechSavvy, System.Drawing.Imaging.ImageFormat.Png);
                img.ScaleToFit(60, 60);
                img.Alignment = iTextSharp.text.Image.UNDERLYING;

                //img.SetAbsolutePosition(10,100);
                img.SetAbsolutePosition(pdfDoc.LeftMargin, pdfDoc.Top - 60);
                pdfDoc.Add(img);


                //pdfDoc.Add(new Phrase("Hola Mundo"));
                using (StringReader sr = new StringReader(PaginaHTML_Texto))
                {
                    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                }

                pdfDoc.Close();
                stream.Close();
            }
            System.Diagnostics.Process.Start(pdfPath);

        }
    }
}
