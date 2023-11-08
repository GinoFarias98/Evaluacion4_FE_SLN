using Evaluacion4_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion4_FE
{
    public partial class Form1 : Form
    {
        ListaUsuarios ListillaF1 = new ListaUsuarios();

        public Form1()
        {
            InitializeComponent();
        }

        private void TxtUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtUsuario.Text))
            {
                TxtUsuario.Text = "Introduzca un usuario";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "Introduzca un usuario")
            {
                TxtUsuario.Text = " ";
                TxtUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtContrasena.Text))
            {
                TxtContrasena.Text = "Introduzca una contraseña";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void TxtContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtContrasena.Text == "Introduzca una contraseña")
            {
                TxtContrasena.Text = "";
                TxtContrasena.ForeColor = Color.Black;
                TxtContrasena.UseSystemPasswordChar = true;

            }
        }

        private void ChBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxContra.Checked == true)
            {
                TxtContrasena.UseSystemPasswordChar = false;
            }
            else
            {
                TxtContrasena.UseSystemPasswordChar = true;

            }
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            this.Hide();
            Form2.Show();
        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {
            if (ValidacionF1() == false)
            {

                MDIParent1 mDIParent1 = new MDIParent1();
                errorProvider1.Clear();
                this.Hide();
                mDIParent1.Show();

            }
            else
            {
                MessageBox.Show("Por favor posicione el cursor sobre el icono de error parpadeante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        public bool ValidacionF1()
        {
            bool Error = false;

            if (string.IsNullOrEmpty(TxtContrasena.Text) || TxtContrasena.Text == "Introduzca una contraseña")
            {
                errorProvider1.SetError(TxtContrasena, "El campo no puede ser vacio.\r\n Recuerde que la contraseña debe ser igual en ambos campos");
                Error = true;
            }

            if (string.IsNullOrEmpty(TxtUsuario.Text) || TxtUsuario.Text == "Introduzca un usuario")
            {
                errorProvider1.SetError(TxtUsuario, "El campo no puede ser vacio");
                Error = true;
            }

            Usuario usu1 = ListillaF1.BuscarUsuario(TxtUsuario.Text);//, TxtContrasena.Text);
            if (usu1.Contrasena != TxtContrasena.Text)
            {
                errorProvider1.SetError(TxtContrasena, "Contraseña erronea, intente nuevamente.");
                Error = true;
            }
            return Error;

            //formulario1


        }


    }
}


       
