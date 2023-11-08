namespace Evaluacion4_FE
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtAceptar = new System.Windows.Forms.Button();
            this.TxtUsuario = new System.Windows.Forms.TextBox();
            this.TxtContrasena = new System.Windows.Forms.TextBox();
            this.BtCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ChBoxContra = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 28);
            this.panel1.TabIndex = 0;
            // 
            // BtAceptar
            // 
            this.BtAceptar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtAceptar.FlatAppearance.BorderSize = 2;
            this.BtAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtAceptar.Location = new System.Drawing.Point(98, 234);
            this.BtAceptar.Name = "BtAceptar";
            this.BtAceptar.Size = new System.Drawing.Size(75, 26);
            this.BtAceptar.TabIndex = 2;
            this.BtAceptar.Text = "Aceptar";
            this.BtAceptar.UseVisualStyleBackColor = true;
            this.BtAceptar.Click += new System.EventHandler(this.BtAceptar_Click);
            // 
            // TxtUsuario
            // 
            this.TxtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TxtUsuario.Location = new System.Drawing.Point(98, 149);
            this.TxtUsuario.Name = "TxtUsuario";
            this.TxtUsuario.Size = new System.Drawing.Size(137, 20);
            this.TxtUsuario.TabIndex = 3;
            this.TxtUsuario.Text = "Introduzca un usuario";
            this.TxtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtUsuario.Enter += new System.EventHandler(this.TxtUsuario_Enter);
            this.TxtUsuario.Leave += new System.EventHandler(this.TxtUsuario_Leave);
            // 
            // TxtContrasena
            // 
            this.TxtContrasena.Location = new System.Drawing.Point(98, 175);
            this.TxtContrasena.Name = "TxtContrasena";
            this.TxtContrasena.Size = new System.Drawing.Size(137, 20);
            this.TxtContrasena.TabIndex = 4;
            this.TxtContrasena.Text = "Introduzca una contraseña";
            this.TxtContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtContrasena.Enter += new System.EventHandler(this.TxtContrasena_Enter);
            this.TxtContrasena.Leave += new System.EventHandler(this.TxtContrasena_Leave);
            // 
            // BtCrear
            // 
            this.BtCrear.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtCrear.FlatAppearance.BorderSize = 2;
            this.BtCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCrear.Location = new System.Drawing.Point(98, 328);
            this.BtCrear.Name = "BtCrear";
            this.BtCrear.Size = new System.Drawing.Size(97, 26);
            this.BtCrear.TabIndex = 5;
            this.BtCrear.Text = "Crear Usuario";
            this.BtCrear.UseVisualStyleBackColor = true;
            this.BtCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "No tiene un usuario aun?";
            // 
            // ChBoxContra
            // 
            this.ChBoxContra.AutoSize = true;
            this.ChBoxContra.Location = new System.Drawing.Point(174, 201);
            this.ChBoxContra.Name = "ChBoxContra";
            this.ChBoxContra.Size = new System.Drawing.Size(61, 17);
            this.ChBoxContra.TabIndex = 7;
            this.ChBoxContra.Text = "Mostrar";
            this.ChBoxContra.UseVisualStyleBackColor = true;
            this.ChBoxContra.CheckedChanged += new System.EventHandler(this.ChBoxContra_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Evaluacion4_FE.Properties.Resources.foto_banco;
            this.pictureBox1.Location = new System.Drawing.Point(113, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 92);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(330, 397);
            this.Controls.Add(this.ChBoxContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtCrear);
            this.Controls.Add(this.TxtContrasena);
            this.Controls.Add(this.TxtUsuario);
            this.Controls.Add(this.BtAceptar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO BILLS";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtAceptar;
        private System.Windows.Forms.TextBox TxtUsuario;
        private System.Windows.Forms.TextBox TxtContrasena;
        private System.Windows.Forms.Button BtCrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChBoxContra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

