namespace UI
{
    partial class FormEmpleados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.DPI = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonListarInactivos = new UI.RJButton();
            this.buttonEditar = new UI.RJButton();
            this.buttonListarActivos = new UI.RJButton();
            this.buttonGuardar = new UI.RJButton();
            this.buttonNuevo = new UI.RJButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 471);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1814, 403);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.AutoSizeColumnModeChanged += new System.Windows.Forms.DataGridViewAutoSizeColumnModeEventHandler(this.dataGridView1_AutoSizeColumnModeChanged);
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBoxTelefono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxDireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxDPI);
            this.groupBox1.Controls.Add(this.DPI);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBoxApellido);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 27.75F);
            this.groupBox1.Location = new System.Drawing.Point(207, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1465, 453);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de Pago";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 42);
            this.label6.TabIndex = 14;
            this.label6.Text = "Genero";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Masculino",
            "Femenino"});
            this.comboBox1.Location = new System.Drawing.Point(222, 374);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(642, 50);
            this.comboBox1.TabIndex = 13;
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(1047, 284);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(394, 50);
            this.textBoxTelefono.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(884, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 42);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono";
            // 
            // textBoxDireccion
            // 
            this.textBoxDireccion.Location = new System.Drawing.Point(1047, 185);
            this.textBoxDireccion.Name = "textBoxDireccion";
            this.textBoxDireccion.Size = new System.Drawing.Size(394, 50);
            this.textBoxDireccion.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(870, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 42);
            this.label4.TabIndex = 9;
            this.label4.Text = "Direccion";
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Font = new System.Drawing.Font("Arial", 27.75F);
            this.textBoxDPI.Location = new System.Drawing.Point(1047, 77);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(394, 50);
            this.textBoxDPI.TabIndex = 8;
            // 
            // DPI
            // 
            this.DPI.AutoSize = true;
            this.DPI.Font = new System.Drawing.Font("Arial", 27.75F);
            this.DPI.Location = new System.Drawing.Point(951, 82);
            this.DPI.Name = "DPI";
            this.DPI.Size = new System.Drawing.Size(79, 42);
            this.DPI.TabIndex = 7;
            this.DPI.Text = "DPI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 84);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de \r\nNacimiento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 284);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(642, 50);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(222, 185);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(642, 50);
            this.textBoxApellido.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 42);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstado.Cursor = System.Windows.Forms.Cursors.Default;
            this.checkBoxEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxEstado.Location = new System.Drawing.Point(891, 376);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(149, 46);
            this.checkBoxEstado.TabIndex = 2;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.Visible = false;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 27.75F);
            this.textBoxNombre.Location = new System.Drawing.Point(222, 77);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(642, 50);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 27.75F);
            this.label1.Location = new System.Drawing.Point(51, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres";
            // 
            // buttonListarInactivos
            // 
            this.buttonListarInactivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListarInactivos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarInactivos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarInactivos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonListarInactivos.BorderRadius = 40;
            this.buttonListarInactivos.BorderSize = 0;
            this.buttonListarInactivos.FlatAppearance.BorderSize = 0;
            this.buttonListarInactivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListarInactivos.Font = new System.Drawing.Font("Arial", 27.75F);
            this.buttonListarInactivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarInactivos.Location = new System.Drawing.Point(1678, 296);
            this.buttonListarInactivos.Name = "buttonListarInactivos";
            this.buttonListarInactivos.Size = new System.Drawing.Size(169, 106);
            this.buttonListarInactivos.TabIndex = 25;
            this.buttonListarInactivos.Text = "Listar Inactivos";
            this.buttonListarInactivos.TextColor = System.Drawing.Color.White;
            this.buttonListarInactivos.UseVisualStyleBackColor = false;
            this.buttonListarInactivos.Click += new System.EventHandler(this.buttonListarInactivos_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonEditar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEditar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonEditar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonEditar.BorderRadius = 40;
            this.buttonEditar.BorderSize = 0;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 27.75F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(1678, 33);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(169, 106);
            this.buttonEditar.TabIndex = 24;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextColor = System.Drawing.Color.White;
            this.buttonEditar.UseVisualStyleBackColor = false;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // buttonListarActivos
            // 
            this.buttonListarActivos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonListarActivos.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarActivos.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonListarActivos.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonListarActivos.BorderRadius = 40;
            this.buttonListarActivos.BorderSize = 0;
            this.buttonListarActivos.FlatAppearance.BorderSize = 0;
            this.buttonListarActivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonListarActivos.Font = new System.Drawing.Font("Arial", 27.75F);
            this.buttonListarActivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarActivos.Location = new System.Drawing.Point(1678, 165);
            this.buttonListarActivos.Name = "buttonListarActivos";
            this.buttonListarActivos.Size = new System.Drawing.Size(169, 106);
            this.buttonListarActivos.TabIndex = 23;
            this.buttonListarActivos.Text = "Listar Activos";
            this.buttonListarActivos.TextColor = System.Drawing.Color.White;
            this.buttonListarActivos.UseVisualStyleBackColor = false;
            this.buttonListarActivos.Click += new System.EventHandler(this.buttonListarActivos_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGuardar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonGuardar.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttonGuardar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonGuardar.BorderRadius = 40;
            this.buttonGuardar.BorderSize = 0;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 27.75F);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(32, 257);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(169, 106);
            this.buttonGuardar.TabIndex = 22;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextColor = System.Drawing.Color.White;
            this.buttonGuardar.UseVisualStyleBackColor = false;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
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
            this.buttonNuevo.Font = new System.Drawing.Font("Arial", 27.75F);
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(32, 88);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(169, 106);
            this.buttonNuevo.TabIndex = 21;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextColor = System.Drawing.Color.White;
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click_1);
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.Fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1858, 871);
            this.Controls.Add(this.buttonListarInactivos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonListarActivos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEmpleados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label DPI;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private RJButton buttonNuevo;
        private RJButton buttonGuardar;
        private RJButton buttonListarActivos;
        private RJButton buttonEditar;
        private RJButton buttonListarInactivos;
    }
}