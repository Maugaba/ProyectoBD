namespace UI
{
    partial class FormMetodoDePago
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
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
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
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-39, 502);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(2007, 434);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 24F);
            this.groupBox1.Location = new System.Drawing.Point(229, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1452, 471);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Metodo de Pago";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(365, 191);
            this.textBoxDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(841, 242);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion";
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxEstado.Location = new System.Drawing.Point(1245, 65);
            this.checkBoxEstado.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(165, 49);
            this.checkBoxEstado.TabIndex = 2;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(365, 74);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(841, 53);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
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
            this.buttonListarInactivos.Font = new System.Drawing.Font("Arial", 24F);
            this.buttonListarInactivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarInactivos.Location = new System.Drawing.Point(1703, 371);
            this.buttonListarInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListarInactivos.Name = "buttonListarInactivos";
            this.buttonListarInactivos.Size = new System.Drawing.Size(208, 101);
            this.buttonListarInactivos.TabIndex = 30;
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
            this.buttonEditar.Enabled = false;
            this.buttonEditar.FlatAppearance.BorderSize = 0;
            this.buttonEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditar.Font = new System.Drawing.Font("Arial", 24F);
            this.buttonEditar.ForeColor = System.Drawing.Color.White;
            this.buttonEditar.Location = new System.Drawing.Point(1703, 70);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(208, 101);
            this.buttonEditar.TabIndex = 29;
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
            this.buttonListarActivos.Font = new System.Drawing.Font("Arial", 24F);
            this.buttonListarActivos.ForeColor = System.Drawing.Color.White;
            this.buttonListarActivos.Location = new System.Drawing.Point(1703, 222);
            this.buttonListarActivos.Margin = new System.Windows.Forms.Padding(4);
            this.buttonListarActivos.Name = "buttonListarActivos";
            this.buttonListarActivos.Size = new System.Drawing.Size(208, 101);
            this.buttonListarActivos.TabIndex = 28;
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
            this.buttonGuardar.Enabled = false;
            this.buttonGuardar.FlatAppearance.BorderSize = 0;
            this.buttonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 24F);
            this.buttonGuardar.ForeColor = System.Drawing.Color.White;
            this.buttonGuardar.Location = new System.Drawing.Point(13, 222);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(208, 101);
            this.buttonGuardar.TabIndex = 27;
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
            this.buttonNuevo.Font = new System.Drawing.Font("Arial", 24F);
            this.buttonNuevo.ForeColor = System.Drawing.Color.White;
            this.buttonNuevo.Location = new System.Drawing.Point(13, 70);
            this.buttonNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(208, 101);
            this.buttonNuevo.TabIndex = 26;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextColor = System.Drawing.Color.White;
            this.buttonNuevo.UseVisualStyleBackColor = false;
            this.buttonNuevo.Click += new System.EventHandler(this.buttonNuevo_Click);
            // 
            // FormMetodoDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.Fondo2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1015);
            this.Controls.Add(this.buttonListarInactivos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonListarActivos);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMetodoDePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMetodoDePago";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMetodoDePago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private RJButton buttonListarInactivos;
        private RJButton buttonEditar;
        private RJButton buttonListarActivos;
        private RJButton buttonGuardar;
        private RJButton buttonNuevo;
    }
}