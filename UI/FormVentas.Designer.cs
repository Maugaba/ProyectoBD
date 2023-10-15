namespace UI
{
    partial class FormVentas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAgregar = new UI.RJButton();
            this.numericUpDownCantidad = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxMetodoPago = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxComentario = new System.Windows.Forms.TextBox();
            this.textBoxDescuento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCliente = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelPrecioSubTotal = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelIdVenta = new System.Windows.Forms.Label();
            this.buttonNuevo = new UI.RJButton();
            this.ButtonVisualizarVenta = new UI.RJButton();
            this.ButtonAnularVenta = new UI.RJButton();
            this.ButtonCrearVenta = new UI.RJButton();
            this.ButtonListarVentasInactivas = new UI.RJButton();
            this.buttonListarVenta = new UI.RJButton();
            this.labelPrecioDescuento = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.numericUpDownCantidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBoxProducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(22, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 206);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venta";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAgregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAgregar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonAgregar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonAgregar.BorderRadius = 40;
            this.buttonAgregar.BorderSize = 0;
            this.buttonAgregar.FlatAppearance.BorderSize = 0;
            this.buttonAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAgregar.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.ForeColor = System.Drawing.Color.White;
            this.buttonAgregar.Location = new System.Drawing.Point(578, 107);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(134, 50);
            this.buttonAgregar.TabIndex = 22;
            this.buttonAgregar.Text = "+ Agregar";
            this.buttonAgregar.TextColor = System.Drawing.Color.White;
            this.buttonAgregar.UseVisualStyleBackColor = false;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // numericUpDownCantidad
            // 
            this.numericUpDownCantidad.Location = new System.Drawing.Point(161, 145);
            this.numericUpDownCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCantidad.Name = "numericUpDownCantidad";
            this.numericUpDownCantidad.Size = new System.Drawing.Size(392, 39);
            this.numericUpDownCantidad.TabIndex = 15;
            this.numericUpDownCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Producto";
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxProducto.Location = new System.Drawing.Point(162, 83);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(391, 40);
            this.comboBoxProducto.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.comboBoxMetodoPago);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxComentario);
            this.groupBox2.Controls.Add(this.textBoxDescuento);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comboBoxCliente);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Enabled = false;
            this.groupBox2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(755, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(684, 334);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // comboBoxMetodoPago
            // 
            this.comboBoxMetodoPago.FormattingEnabled = true;
            this.comboBoxMetodoPago.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxMetodoPago.Location = new System.Drawing.Point(199, 128);
            this.comboBoxMetodoPago.Name = "comboBoxMetodoPago";
            this.comboBoxMetodoPago.Size = new System.Drawing.Size(391, 40);
            this.comboBoxMetodoPago.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 32);
            this.label1.TabIndex = 32;
            this.label1.Text = "Descuento";
            // 
            // textBoxComentario
            // 
            this.textBoxComentario.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComentario.Location = new System.Drawing.Point(199, 189);
            this.textBoxComentario.Multiline = true;
            this.textBoxComentario.Name = "textBoxComentario";
            this.textBoxComentario.Size = new System.Drawing.Size(391, 120);
            this.textBoxComentario.TabIndex = 25;
            // 
            // textBoxDescuento
            // 
            this.textBoxDescuento.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDescuento.Location = new System.Drawing.Point(199, 74);
            this.textBoxDescuento.Name = "textBoxDescuento";
            this.textBoxDescuento.ReadOnly = true;
            this.textBoxDescuento.Size = new System.Drawing.Size(391, 39);
            this.textBoxDescuento.TabIndex = 33;
            this.textBoxDescuento.TextChanged += new System.EventHandler(this.textBoxDescuento_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 32);
            this.label5.TabIndex = 24;
            this.label5.Text = "Comentario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Cliente";
            // 
            // comboBoxCliente
            // 
            this.comboBoxCliente.FormattingEnabled = true;
            this.comboBoxCliente.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBoxCliente.Location = new System.Drawing.Point(199, 28);
            this.comboBoxCliente.Name = "comboBoxCliente";
            this.comboBoxCliente.Size = new System.Drawing.Size(391, 40);
            this.comboBoxCliente.TabIndex = 13;
            this.comboBoxCliente.SelectedIndexChanged += new System.EventHandler(this.comboBoxCliente_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 64);
            this.label4.TabIndex = 0;
            this.label4.Text = "Metodo de\r\nPago\r\n";
            // 
            // labelPrecioSubTotal
            // 
            this.labelPrecioSubTotal.AutoSize = true;
            this.labelPrecioSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioSubTotal.Location = new System.Drawing.Point(102, 255);
            this.labelPrecioSubTotal.Name = "labelPrecioSubTotal";
            this.labelPrecioSubTotal.Size = new System.Drawing.Size(203, 31);
            this.labelPrecioSubTotal.TabIndex = 23;
            this.labelPrecioSubTotal.Text = "Subtotal: Q0.00";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 457);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1424, 349);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // labelIdVenta
            // 
            this.labelIdVenta.AutoSize = true;
            this.labelIdVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdVenta.Location = new System.Drawing.Point(1260, 388);
            this.labelIdVenta.Name = "labelIdVenta";
            this.labelIdVenta.Size = new System.Drawing.Size(0, 27);
            this.labelIdVenta.TabIndex = 30;
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNuevo.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNuevo.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonNuevo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonNuevo.BorderRadius = 40;
            this.buttonNuevo.BorderSize = 0;
            this.buttonNuevo.FlatAppearance.BorderSize = 0;
            this.buttonNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNuevo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(322, 388);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(135, 63);
            this.buttonNuevo.TabIndex = 31;
            this.buttonNuevo.Text = "Nueva venta";
            this.buttonNuevo.TextColor = System.Drawing.Color.White;
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // ButtonVisualizarVenta
            // 
            this.ButtonVisualizarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonVisualizarVenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonVisualizarVenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonVisualizarVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonVisualizarVenta.BorderRadius = 40;
            this.ButtonVisualizarVenta.BorderSize = 0;
            this.ButtonVisualizarVenta.Enabled = false;
            this.ButtonVisualizarVenta.FlatAppearance.BorderSize = 0;
            this.ButtonVisualizarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonVisualizarVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonVisualizarVenta.ForeColor = System.Drawing.Color.White;
            this.ButtonVisualizarVenta.Location = new System.Drawing.Point(1060, 388);
            this.ButtonVisualizarVenta.Name = "ButtonVisualizarVenta";
            this.ButtonVisualizarVenta.Size = new System.Drawing.Size(135, 63);
            this.ButtonVisualizarVenta.TabIndex = 29;
            this.ButtonVisualizarVenta.Text = "Visualizar Venta";
            this.ButtonVisualizarVenta.TextColor = System.Drawing.Color.White;
            this.ButtonVisualizarVenta.UseVisualStyleBackColor = false;
            this.ButtonVisualizarVenta.Click += new System.EventHandler(this.ButtonVisualizarVenta_Click);
            // 
            // ButtonAnularVenta
            // 
            this.ButtonAnularVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonAnularVenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonAnularVenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonAnularVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAnularVenta.BorderRadius = 40;
            this.ButtonAnularVenta.BorderSize = 0;
            this.ButtonAnularVenta.Enabled = false;
            this.ButtonAnularVenta.FlatAppearance.BorderSize = 0;
            this.ButtonAnularVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAnularVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAnularVenta.ForeColor = System.Drawing.Color.White;
            this.ButtonAnularVenta.Location = new System.Drawing.Point(610, 388);
            this.ButtonAnularVenta.Name = "ButtonAnularVenta";
            this.ButtonAnularVenta.Size = new System.Drawing.Size(135, 63);
            this.ButtonAnularVenta.TabIndex = 28;
            this.ButtonAnularVenta.Text = "Anular Venta";
            this.ButtonAnularVenta.TextColor = System.Drawing.Color.White;
            this.ButtonAnularVenta.UseVisualStyleBackColor = false;
            // 
            // ButtonCrearVenta
            // 
            this.ButtonCrearVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCrearVenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCrearVenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonCrearVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonCrearVenta.BorderRadius = 40;
            this.ButtonCrearVenta.BorderSize = 0;
            this.ButtonCrearVenta.FlatAppearance.BorderSize = 0;
            this.ButtonCrearVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCrearVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCrearVenta.ForeColor = System.Drawing.Color.White;
            this.ButtonCrearVenta.Location = new System.Drawing.Point(463, 388);
            this.ButtonCrearVenta.Name = "ButtonCrearVenta";
            this.ButtonCrearVenta.Size = new System.Drawing.Size(135, 63);
            this.ButtonCrearVenta.TabIndex = 27;
            this.ButtonCrearVenta.Text = "Crear Venta";
            this.ButtonCrearVenta.TextColor = System.Drawing.Color.White;
            this.ButtonCrearVenta.UseVisualStyleBackColor = false;
            this.ButtonCrearVenta.Click += new System.EventHandler(this.ButtonCrearVenta_Click);
            // 
            // ButtonListarVentasInactivas
            // 
            this.ButtonListarVentasInactivas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonListarVentasInactivas.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonListarVentasInactivas.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.ButtonListarVentasInactivas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonListarVentasInactivas.BorderRadius = 40;
            this.ButtonListarVentasInactivas.BorderSize = 0;
            this.ButtonListarVentasInactivas.FlatAppearance.BorderSize = 0;
            this.ButtonListarVentasInactivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonListarVentasInactivas.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonListarVentasInactivas.ForeColor = System.Drawing.Color.White;
            this.ButtonListarVentasInactivas.Location = new System.Drawing.Point(892, 388);
            this.ButtonListarVentasInactivas.Name = "ButtonListarVentasInactivas";
            this.ButtonListarVentasInactivas.Size = new System.Drawing.Size(162, 63);
            this.ButtonListarVentasInactivas.TabIndex = 26;
            this.ButtonListarVentasInactivas.Text = "Listar Ventas Inactivas";
            this.ButtonListarVentasInactivas.TextColor = System.Drawing.Color.White;
            this.ButtonListarVentasInactivas.UseVisualStyleBackColor = false;
            this.ButtonListarVentasInactivas.Click += new System.EventHandler(this.ButtonListarVentasInactivas_Click);
            // 
            // buttonListarVenta
            // 
            this.buttonListarVenta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListarVenta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarVenta.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarVenta.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonListarVenta.BorderRadius = 40;
            this.buttonListarVenta.BorderSize = 0;
            this.buttonListarVenta.FlatAppearance.BorderSize = 0;
            this.buttonListarVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListarVenta.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarVenta.ForeColor = System.Drawing.Color.White;
            this.buttonListarVenta.Location = new System.Drawing.Point(751, 388);
            this.buttonListarVenta.Name = "buttonListarVenta";
            this.buttonListarVenta.Size = new System.Drawing.Size(135, 63);
            this.buttonListarVenta.TabIndex = 24;
            this.buttonListarVenta.Text = "Listar Ventas";
            this.buttonListarVenta.TextColor = System.Drawing.Color.White;
            this.buttonListarVenta.UseVisualStyleBackColor = false;
            this.buttonListarVenta.Click += new System.EventHandler(this.buttonListarVenta_Click);
            // 
            // labelPrecioDescuento
            // 
            this.labelPrecioDescuento.AutoSize = true;
            this.labelPrecioDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecioDescuento.Location = new System.Drawing.Point(71, 286);
            this.labelPrecioDescuento.Name = "labelPrecioDescuento";
            this.labelPrecioDescuento.Size = new System.Drawing.Size(234, 31);
            this.labelPrecioDescuento.TabIndex = 32;
            this.labelPrecioDescuento.Text = "Descuento: Q0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(141, 317);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(164, 31);
            this.labelTotal.TabIndex = 33;
            this.labelTotal.Text = "Total: Q0.00";
            // 
            // FormVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 842);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelPrecioDescuento);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.labelIdVenta);
            this.Controls.Add(this.labelPrecioSubTotal);
            this.Controls.Add(this.ButtonVisualizarVenta);
            this.Controls.Add(this.ButtonAnularVenta);
            this.Controls.Add(this.ButtonCrearVenta);
            this.Controls.Add(this.ButtonListarVentasInactivas);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonListarVenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormVentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCantidad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownCantidad;
        private RJButton buttonAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelPrecioSubTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxComentario;
        private RJButton buttonListarVenta;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RJButton ButtonListarVentasInactivas;
        private RJButton ButtonCrearVenta;
        private RJButton ButtonAnularVenta;
        private RJButton ButtonVisualizarVenta;
        private System.Windows.Forms.Label labelIdVenta;
        private RJButton buttonNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescuento;
        private System.Windows.Forms.ComboBox comboBoxMetodoPago;
        private System.Windows.Forms.Label labelPrecioDescuento;
        private System.Windows.Forms.Label labelTotal;
    }
}