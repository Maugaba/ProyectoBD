namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Ocultar = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.ButtonIniciarSesion = new UI.RJButton();
            this.rolesTableAdapter1 = new DAL.DataSetVentasTableAdapters.RolesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUsuario.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsuario.Location = new System.Drawing.Point(187, 140);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(364, 50);
            this.textBoxUsuario.TabIndex = 1;
            this.textBoxUsuario.Text = "Usuario";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(187, 241);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(364, 50);
            this.textBoxContraseña.TabIndex = 2;
            this.textBoxContraseña.Text = "Contraseña";
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::UI.Properties.Resources.dis;
            this.pictureBox1.Location = new System.Drawing.Point(658, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(325, 265);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::UI.Properties.Resources.Usarios;
            this.pictureBox2.Location = new System.Drawing.Point(96, 122);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 79);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::UI.Properties.Resources._lock;
            this.pictureBox3.Location = new System.Drawing.Point(96, 230);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(85, 70);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // Ocultar
            // 
            this.Ocultar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ocultar.BackColor = System.Drawing.Color.Transparent;
            this.Ocultar.Image = global::UI.Properties.Resources.eyelashes;
            this.Ocultar.Location = new System.Drawing.Point(568, 230);
            this.Ocultar.Name = "Ocultar";
            this.Ocultar.Size = new System.Drawing.Size(66, 70);
            this.Ocultar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ocultar.TabIndex = 10;
            this.Ocultar.TabStop = false;
            this.Ocultar.Click += new System.EventHandler(this.Ocultar_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::UI.Properties.Resources.eye;
            this.pictureBox4.Location = new System.Drawing.Point(568, 230);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(66, 70);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ButtonIniciarSesion
            // 
            this.ButtonIniciarSesion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonIniciarSesion.BackColor = System.Drawing.Color.RoyalBlue;
            this.ButtonIniciarSesion.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.ButtonIniciarSesion.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonIniciarSesion.BorderRadius = 40;
            this.ButtonIniciarSesion.BorderSize = 0;
            this.ButtonIniciarSesion.FlatAppearance.BorderSize = 0;
            this.ButtonIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonIniciarSesion.Font = new System.Drawing.Font("Arial", 27.75F);
            this.ButtonIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.ButtonIniciarSesion.Location = new System.Drawing.Point(412, 340);
            this.ButtonIniciarSesion.Name = "ButtonIniciarSesion";
            this.ButtonIniciarSesion.Size = new System.Drawing.Size(175, 100);
            this.ButtonIniciarSesion.TabIndex = 0;
            this.ButtonIniciarSesion.Text = "Iniciar Sesion";
            this.ButtonIniciarSesion.TextColor = System.Drawing.Color.White;
            this.ButtonIniciarSesion.UseVisualStyleBackColor = false;
            this.ButtonIniciarSesion.Click += new System.EventHandler(this.ButtonIniciarSesion_Click);
            // 
            // rolesTableAdapter1
            // 
            this.rolesTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(983, 568);
            this.Controls.Add(this.ButtonIniciarSesion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.Ocultar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ocultar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox Ocultar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private DAL.DataSetVentasTableAdapters.RolesTableAdapter rolesTableAdapter1;
        private RJButton ButtonIniciarSesion;
    }
}

