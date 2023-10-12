namespace UI
{
    partial class FormSolicitudProductoProveedor
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
            this.textBoxDPI = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DPI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.buttonListarInactivos = new UI.RJButton();
            this.buttonEditar = new UI.RJButton();
            this.buttonListarActivos = new UI.RJButton();
            this.buttonGuardar = new UI.RJButton();
            this.buttonNuevo = new UI.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxProducto = new System.Windows.Forms.ComboBox();
            this.comboBoxProveedor = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBoxProveedor);
            this.groupBox1.Controls.Add(this.comboBoxProducto);
            this.groupBox1.Controls.Add(this.textBoxDPI);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DPI);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 354);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud Producto Proveedor";
            // 
            // textBoxDPI
            // 
            this.textBoxDPI.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDPI.Location = new System.Drawing.Point(446, 249);
            this.textBoxDPI.Name = "textBoxDPI";
            this.textBoxDPI.Size = new System.Drawing.Size(391, 39);
            this.textBoxDPI.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Producto";
            // 
            // DPI
            // 
            this.DPI.AutoSize = true;
            this.DPI.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DPI.Location = new System.Drawing.Point(191, 249);
            this.DPI.Name = "DPI";
            this.DPI.Size = new System.Drawing.Size(249, 32);
            this.DPI.TabIndex = 7;
            this.DPI.Text = "Cantidad Solicitada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Proveedor";
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
            this.checkBoxEstado.Location = new System.Drawing.Point(937, 162);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(115, 36);
            this.checkBoxEstado.TabIndex = 2;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.Visible = false;
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
            this.buttonListarInactivos.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonListarInactivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarInactivos.Location = new System.Drawing.Point(1291, 292);
            this.buttonListarInactivos.Name = "buttonListarInactivos";
            this.buttonListarInactivos.Size = new System.Drawing.Size(135, 85);
            this.buttonListarInactivos.TabIndex = 30;
            this.buttonListarInactivos.Text = "Listar Inactivos";
            this.buttonListarInactivos.TextColor = System.Drawing.Color.White;
            this.buttonListarInactivos.UseVisualStyleBackColor = false;
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
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 20.25F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(1291, 72);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(135, 85);
            this.buttonEditar.TabIndex = 29;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.TextColor = System.Drawing.Color.White;
            this.buttonEditar.UseVisualStyleBackColor = false;
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
            this.buttonListarActivos.Font = new System.Drawing.Font("Arial", 20.25F);
            this.buttonListarActivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarActivos.Location = new System.Drawing.Point(1291, 188);
            this.buttonListarActivos.Name = "buttonListarActivos";
            this.buttonListarActivos.Size = new System.Drawing.Size(135, 85);
            this.buttonListarActivos.TabIndex = 28;
            this.buttonListarActivos.Text = "Listar Activos";
            this.buttonListarActivos.TextColor = System.Drawing.Color.White;
            this.buttonListarActivos.UseVisualStyleBackColor = false;
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
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 20.25F);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(-5, 224);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(135, 85);
            this.buttonGuardar.TabIndex = 27;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextColor = System.Drawing.Color.White;
            this.buttonGuardar.UseVisualStyleBackColor = false;
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
            this.buttonNuevo.Font = new System.Drawing.Font("Arial", 20.25F);
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(-6, 92);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(135, 85);
            this.buttonNuevo.TabIndex = 26;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextColor = System.Drawing.Color.White;
            this.buttonNuevo.UseVisualStyleBackColor = false;
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
            this.dataGridView1.TabIndex = 31;
            // 
            // comboBoxProducto
            // 
            this.comboBoxProducto.FormattingEnabled = true;
            this.comboBoxProducto.Location = new System.Drawing.Point(446, 83);
            this.comboBoxProducto.Name = "comboBoxProducto";
            this.comboBoxProducto.Size = new System.Drawing.Size(391, 40);
            this.comboBoxProducto.TabIndex = 15;
            // 
            // comboBoxProveedor
            // 
            this.comboBoxProveedor.FormattingEnabled = true;
            this.comboBoxProveedor.Location = new System.Drawing.Point(446, 163);
            this.comboBoxProveedor.Name = "comboBoxProveedor";
            this.comboBoxProveedor.Size = new System.Drawing.Size(391, 40);
            this.comboBoxProveedor.TabIndex = 16;
            // 
            // FormSolicitudProductoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 842);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonListarInactivos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonListarActivos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormSolicitudProductoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSolicitudProductoProveedor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDPI;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label DPI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private RJButton buttonListarInactivos;
        private RJButton buttonEditar;
        private RJButton buttonListarActivos;
        private RJButton buttonGuardar;
        private RJButton buttonNuevo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxProveedor;
        private System.Windows.Forms.ComboBox comboBoxProducto;
    }
}