namespace Evaluacion4_FE
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ChBoxForm2 = new System.Windows.Forms.CheckBox();
            this.TxtCrearContrasena = new System.Windows.Forms.TextBox();
            this.TxtCrearUsuario = new System.Windows.Forms.TextBox();
            this.BtCrear = new System.Windows.Forms.Button();
            this.TxtRepContra = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 28);
            this.panel1.TabIndex = 1;
            // 
            // ChBoxForm2
            // 
            this.ChBoxForm2.AutoSize = true;
            this.ChBoxForm2.Location = new System.Drawing.Point(206, 125);
            this.ChBoxForm2.Name = "ChBoxForm2";
            this.ChBoxForm2.Size = new System.Drawing.Size(61, 17);
            this.ChBoxForm2.TabIndex = 11;
            this.ChBoxForm2.Text = "Mostrar";
            this.ChBoxForm2.UseVisualStyleBackColor = true;
            this.ChBoxForm2.CheckedChanged += new System.EventHandler(this.ChBoxContra_CheckedChanged);
            // 
            // TxtCrearContrasena
            // 
            this.TxtCrearContrasena.Location = new System.Drawing.Point(80, 73);
            this.TxtCrearContrasena.Name = "TxtCrearContrasena";
            this.TxtCrearContrasena.Size = new System.Drawing.Size(187, 20);
            this.TxtCrearContrasena.TabIndex = 10;
            this.TxtCrearContrasena.Text = "Introduzca una contraseña";
            this.TxtCrearContrasena.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCrearContrasena.Enter += new System.EventHandler(this.TxtCrearContrasena_Enter);
            this.TxtCrearContrasena.Leave += new System.EventHandler(this.TxtCrearContrasena_Leave);
            // 
            // TxtCrearUsuario
            // 
            this.TxtCrearUsuario.Location = new System.Drawing.Point(80, 47);
            this.TxtCrearUsuario.Name = "TxtCrearUsuario";
            this.TxtCrearUsuario.Size = new System.Drawing.Size(187, 20);
            this.TxtCrearUsuario.TabIndex = 9;
            this.TxtCrearUsuario.Text = "Introduzca un usuario";
            this.TxtCrearUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCrearUsuario.Enter += new System.EventHandler(this.TxtCrearUsuario_Enter);
            this.TxtCrearUsuario.Leave += new System.EventHandler(this.TxtCrearUsuario_Leave);
            // 
            // BtCrear
            // 
            this.BtCrear.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.BtCrear.FlatAppearance.BorderSize = 2;
            this.BtCrear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BtCrear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BtCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtCrear.Location = new System.Drawing.Point(80, 166);
            this.BtCrear.Name = "BtCrear";
            this.BtCrear.Size = new System.Drawing.Size(87, 26);
            this.BtCrear.TabIndex = 8;
            this.BtCrear.Text = "Crear Usuario";
            this.BtCrear.UseVisualStyleBackColor = true;
            this.BtCrear.Click += new System.EventHandler(this.BtCrear_Click);
            // 
            // TxtRepContra
            // 
            this.TxtRepContra.Location = new System.Drawing.Point(80, 99);
            this.TxtRepContra.Name = "TxtRepContra";
            this.TxtRepContra.Size = new System.Drawing.Size(187, 20);
            this.TxtRepContra.TabIndex = 12;
            this.TxtRepContra.Text = "Introduzca nuevamente la contraseña\r\n\r\n";
            this.TxtRepContra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtRepContra.Enter += new System.EventHandler(this.TxtRepContra_Enter);
            this.TxtRepContra.Leave += new System.EventHandler(this.TxtRepContra_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 204);
            this.Controls.Add(this.TxtRepContra);
            this.Controls.Add(this.ChBoxForm2);
            this.Controls.Add(this.TxtCrearContrasena);
            this.Controls.Add(this.TxtCrearUsuario);
            this.Controls.Add(this.BtCrear);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANCO BILLS / CREACION USUARIO";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox ChBoxForm2;
        private System.Windows.Forms.TextBox TxtCrearContrasena;
        private System.Windows.Forms.TextBox TxtCrearUsuario;
        private System.Windows.Forms.Button BtCrear;
        private System.Windows.Forms.TextBox TxtRepContra;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}