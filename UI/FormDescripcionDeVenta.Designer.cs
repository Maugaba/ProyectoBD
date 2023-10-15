namespace UI
{
    partial class FormDescripcionDeVenta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonVisualizarVenta = new UI.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelLetra = new System.Windows.Forms.Label();
            this.labelCorrelativo = new System.Windows.Forms.Label();
            this.labelMetododePago = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.labelCliente = new System.Windows.Forms.Label();
            this.labelNIT = new System.Windows.Forms.Label();
            this.labelComentario = new System.Windows.Forms.Label();
            this.labelSubtotal = new System.Windows.Forms.Label();
            this.labelDescuento = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelIdFactura = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 421);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1424, 389);
            this.dataGridView1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Empleado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Correlativo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1103, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 32);
            this.label7.TabIndex = 30;
            this.label7.Text = "Subtotal: Q";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1072, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 32);
            this.label8.TabIndex = 32;
            this.label8.Text = "Descuento: Q";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1146, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 32);
            this.label9.TabIndex = 34;
            this.label9.Text = "Total: Q";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(63, 336);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 32);
            this.label10.TabIndex = 37;
            this.label10.Text = "Comentario:";
            // 
            // ButtonVisualizarVenta
            // 
            this.ButtonVisualizarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonVisualizarVenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonVisualizarVenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonVisualizarVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonVisualizarVenta.BorderRadius = 40;
            this.ButtonVisualizarVenta.BorderSize = 0;
            this.ButtonVisualizarVenta.FlatAppearance.BorderSize = 0;
            this.ButtonVisualizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisualizarVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVisualizarVenta.ForeColor = System.Drawing.Color.White;
            this.ButtonVisualizarVenta.Location = new System.Drawing.Point(1229, 37);
            this.ButtonVisualizarVenta.Name = "ButtonVisualizarVenta";
            this.ButtonVisualizarVenta.Size = new System.Drawing.Size(135, 50);
            this.ButtonVisualizarVenta.TabIndex = 38;
            this.ButtonVisualizarVenta.Text = "Imprimir";
            this.ButtonVisualizarVenta.TextColor = System.Drawing.Color.White;
            this.ButtonVisualizarVenta.UseVisualStyleBackColor = false;
            this.ButtonVisualizarVenta.Click += new System.EventHandler(this.ButtonVisualizarVenta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI.Properties.Resources.TechSavvy;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(163, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 32);
            this.label4.TabIndex = 39;
            this.label4.Text = "NIT:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(221, 32);
            this.label11.TabIndex = 40;
            this.label11.Text = "Metodo de Pago:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(163, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 32);
            this.label6.TabIndex = 41;
            this.label6.Text = "Factura Serie: ";
            // 
            // labelLetra
            // 
            this.labelLetra.AutoSize = true;
            this.labelLetra.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLetra.Location = new System.Drawing.Point(363, 44);
            this.labelLetra.Name = "labelLetra";
            this.labelLetra.Size = new System.Drawing.Size(22, 32);
            this.labelLetra.TabIndex = 42;
            this.labelLetra.Text = ":";
            // 
            // labelCorrelativo
            // 
            this.labelCorrelativo.AutoSize = true;
            this.labelCorrelativo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCorrelativo.Location = new System.Drawing.Point(363, 76);
            this.labelCorrelativo.Name = "labelCorrelativo";
            this.labelCorrelativo.Size = new System.Drawing.Size(22, 32);
            this.labelCorrelativo.TabIndex = 43;
            this.labelCorrelativo.Text = ":";
            // 
            // labelMetododePago
            // 
            this.labelMetododePago.AutoSize = true;
            this.labelMetododePago.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMetododePago.Location = new System.Drawing.Point(231, 162);
            this.labelMetododePago.Name = "labelMetododePago";
            this.labelMetododePago.Size = new System.Drawing.Size(22, 32);
            this.labelMetododePago.TabIndex = 44;
            this.labelMetododePago.Text = ":";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmpleado.Location = new System.Drawing.Point(231, 206);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(22, 32);
            this.labelEmpleado.TabIndex = 45;
            this.labelEmpleado.Text = ":";
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(231, 251);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(22, 32);
            this.labelCliente.TabIndex = 46;
            this.labelCliente.Text = ":";
            // 
            // labelNIT
            // 
            this.labelNIT.AutoSize = true;
            this.labelNIT.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNIT.Location = new System.Drawing.Point(231, 293);
            this.labelNIT.Name = "labelNIT";
            this.labelNIT.Size = new System.Drawing.Size(22, 32);
            this.labelNIT.TabIndex = 47;
            this.labelNIT.Text = ":";
            // 
            // labelComentario
            // 
            this.labelComentario.AutoSize = true;
            this.labelComentario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComentario.Location = new System.Drawing.Point(231, 336);
            this.labelComentario.Name = "labelComentario";
            this.labelComentario.Size = new System.Drawing.Size(22, 32);
            this.labelComentario.TabIndex = 49;
            this.labelComentario.Text = ":";
            // 
            // labelSubtotal
            // 
            this.labelSubtotal.AutoSize = true;
            this.labelSubtotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubtotal.Location = new System.Drawing.Point(1260, 162);
            this.labelSubtotal.Name = "labelSubtotal";
            this.labelSubtotal.Size = new System.Drawing.Size(22, 32);
            this.labelSubtotal.TabIndex = 50;
            this.labelSubtotal.Text = ":";
            // 
            // labelDescuento
            // 
            this.labelDescuento.AutoSize = true;
            this.labelDescuento.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescuento.Location = new System.Drawing.Point(1260, 206);
            this.labelDescuento.Name = "labelDescuento";
            this.labelDescuento.Size = new System.Drawing.Size(22, 32);
            this.labelDescuento.TabIndex = 51;
            this.labelDescuento.Text = ":";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(1260, 251);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(22, 32);
            this.labelTotal.TabIndex = 52;
            this.labelTotal.Text = ":";
            // 
            // labelIdFactura
            // 
            this.labelIdFactura.AutoSize = true;
            this.labelIdFactura.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdFactura.Location = new System.Drawing.Point(363, 12);
            this.labelIdFactura.Name = "labelIdFactura";
            this.labelIdFactura.Size = new System.Drawing.Size(22, 32);
            this.labelIdFactura.TabIndex = 54;
            this.labelIdFactura.Text = ":";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(184, 12);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(173, 32);
            this.labelId.TabIndex = 53;
            this.labelId.Text = "No. Factura: ";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(823, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(22, 32);
            this.labelFecha.TabIndex = 56;
            this.labelFecha.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(644, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 32);
            this.label13.TabIndex = 55;
            this.label13.Text = "Fecha: ";
            // 
            // FormDescripcionDeVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 842);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelIdFactura);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelDescuento);
            this.Controls.Add(this.labelSubtotal);
            this.Controls.Add(this.labelComentario);
            this.Controls.Add(this.labelNIT);
            this.Controls.Add(this.labelCliente);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.labelMetododePago);
            this.Controls.Add(this.labelCorrelativo);
            this.Controls.Add(this.labelLetra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonVisualizarVenta);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormDescripcionDeVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDescripcionDeVenta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormDescripcionDeVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private RJButton ButtonVisualizarVenta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelLetra;
        private System.Windows.Forms.Label labelCorrelativo;
        private System.Windows.Forms.Label labelMetododePago;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Label labelNIT;
        private System.Windows.Forms.Label labelComentario;
        private System.Windows.Forms.Label labelSubtotal;
        private System.Windows.Forms.Label labelDescuento;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelIdFactura;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label13;
    }
}