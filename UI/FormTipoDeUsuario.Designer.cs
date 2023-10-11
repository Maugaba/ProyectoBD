namespace UI
{
    partial class FormTipoDeUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.Label();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNuevo = new UI.RJButton();
            this.buttonGuardar = new UI.RJButton();
            this.buttonEditar = new UI.RJButton();
            this.buttonListarActivos = new UI.RJButton();
            this.buttonListarInactivos = new UI.RJButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxDescripcion);
            this.groupBox1.Controls.Add(this.Descripcion);
            this.groupBox1.Controls.Add(this.checkBoxEstado);
            this.groupBox1.Controls.Add(this.textBoxNombre);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(134, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1132, 354);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos De Usuarios";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(176, 140);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(375, 180);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(13, 143);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(157, 32);
            this.Descripcion.TabIndex = 3;
            this.Descripcion.Text = "Descripcion";
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
            this.checkBoxEstado.Location = new System.Drawing.Point(631, 143);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.Size = new System.Drawing.Size(115, 36);
            this.checkBoxEstado.TabIndex = 2;
            this.checkBoxEstado.Text = "Estado";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            this.checkBoxEstado.Visible = false;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(176, 68);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(375, 39);
            this.textBoxNombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descuento %";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(752, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(337, 39);
            this.textBox1.TabIndex = 6;
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
            this.buttonNuevo.TabIndex = 22;
            this.buttonNuevo.Text = "Nuevo";
            this.buttonNuevo.TextColor = System.Drawing.Color.White;
            this.buttonNuevo.UseVisualStyleBackColor = false;
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
            this.buttonGuardar.TabIndex = 23;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.TextColor = System.Drawing.Color.White;
            this.buttonGuardar.UseVisualStyleBackColor = false;
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
            this.buttonEditar.TabIndex = 25;
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
            this.buttonListarActivos.TabIndex = 26;
            this.buttonListarActivos.Text = "Listar Activos";
            this.buttonListarActivos.TextColor = System.Drawing.Color.White;
            this.buttonListarActivos.UseVisualStyleBackColor = false;
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
            this.buttonListarInactivos.TabIndex = 27;
            this.buttonListarInactivos.Text = "Listar Inactivos";
            this.buttonListarInactivos.TextColor = System.Drawing.Color.White;
            this.buttonListarInactivos.UseVisualStyleBackColor = false;
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
            this.dataGridView1.TabIndex = 28;
            // 
            // FormTipoDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 842);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonListarInactivos);
            this.Controls.Add(this.buttonListarActivos);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTipoDeUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTipoDeUsuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private RJButton buttonNuevo;
        private RJButton buttonGuardar;
        private RJButton buttonEditar;
        private RJButton buttonListarActivos;
        private RJButton buttonListarInactivos;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}