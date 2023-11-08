using Evaluacion4_BE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion4_FE
{
    public partial class Form2 : Form
    {
        Usuario usuario = new Usuario();
        ListaUsuarios Listilla { get; set; } = new ListaUsuarios();
        public Form2()
        {
            InitializeComponent();
        }

        private void TxtCrearUsuario_Enter(object sender, EventArgs e)
        {
            if (TxtCrearUsuario.Text == "Introduzca un usuario")
            {
                TxtCrearUsuario.Text = "";
                TxtCrearUsuario.ForeColor = Color.Black;

            }
        }

        private void TxtCrearUsuario_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCrearUsuario.Text))
            {
                TxtCrearUsuario.Text = "Introduzca un usuario";
                TxtCrearUsuario.ForeColor = Color.Black;
            }
        }

        private void TxtCrearContrasena_Enter(object sender, EventArgs e)
        {
            if (TxtCrearContrasena.Text == "Introduzca una contraseña")
            {
                TxtCrearContrasena.Text = "";
                TxtCrearContrasena.ForeColor = Color.Black;
                TxtCrearContrasena.UseSystemPasswordChar = true;
            }
        }

        private void TxtCrearContrasena_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtCrearContrasena.Text))
            {
                TxtCrearContrasena.Text = "Introduzca una contraseña";
                TxtCrearContrasena.ForeColor = Color.Black;
                TxtCrearContrasena.UseSystemPasswordChar = false;

            }
        }

        private void TxtRepContra_Enter(object sender, EventArgs e)
        {
            if (TxtRepContra.Text == "Introduzca nuevamente la contraseña\r\n\r\n")
            {
                TxtRepContra.Text = "";
                TxtRepContra.ForeColor = Color.Black;
                TxtRepContra.UseSystemPasswordChar= true;
            }
        }

        private void TxtRepContra_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtRepContra.Text))
            {
                TxtRepContra.Text = "Introduzca nuevamente la contraseña\r\n\r\n";
                TxtRepContra.ForeColor = Color.Black;
                TxtRepContra.UseSystemPasswordChar = false;

            }
        }

        private void ChBoxContra_CheckedChanged(object sender, EventArgs e)
        {
            if (ChBoxForm2.Checked==true)
            {
                TxtRepContra.UseSystemPasswordChar = false;
                TxtCrearContrasena.UseSystemPasswordChar = false;

            }
            else
            {
                TxtRepContra.UseSystemPasswordChar = true;
                TxtCrearContrasena.UseSystemPasswordChar = true;
            }
        }

        private void BtCrear_Click(object sender, EventArgs e)
        {
            if (ValidacionF2()==false)
            {
                // Usuario usu = Listilla.BuscarUsuario(TxtCrearUsuario.Text);

                // if (usu.NombreUsuario == TxtCrearUsuario.Text)
                // {
                //    errorProvider1.SetError(TxtCrearUsuario, "Usuario invalido, intente nuevamente.");
                //    MessageBox.Show("Por favor posicione el cursor sobre el icono de error parpadeante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // }
                // else
                // {
                
                    Form1 Form1 = new Form1();
                    errorProvider1.Clear();
                    usuario.Agregar(TxtCrearUsuario.Text, TxtCrearContrasena.Text);
                    Listilla.InsertUsuario(usuario);
                    usuario.Agregar(TxtCrearUsuario.Text, TxtCrearContrasena.Text);
                    MessageBox.Show("datos cargados correctamente.", "Validaciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    Form1.Show();
                // }
            }
            else
            {
                MessageBox.Show("Por favor posicione el cursor sobre el icono de error parpadeante.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtCrearContrasena.Clear();
                TxtRepContra.Clear();
            }
        }

        public bool ValidacionF2()
        {
           //Usuario Usu = Listilla.BuscarUsuario(TxtCrearUsuario.Text);
            bool Error = false;

            if (string.IsNullOrEmpty(TxtCrearContrasena.Text) || TxtCrearContrasena.Text != TxtRepContra.Text)
            {
                errorProvider1.SetError(TxtCrearContrasena, "El campo no puede ser vacio.\r\n Recuerde que la contraseña debe ser igual en ambos campos.");
                Error = true;
            }

            if (string.IsNullOrEmpty(TxtCrearUsuario.Text) || TxtCrearUsuario.Text == "Introduzca un usuario.")
            {
                errorProvider1.SetError(TxtCrearUsuario, "El campo no puede ser vacio.");
                Error = true;
            }
            Usuario usu = Listilla.BuscarUsuario(TxtCrearUsuario.Text);

            if (usu.NombreUsuario == TxtCrearUsuario.Text)
            {
                errorProvider1.SetError(TxtCrearUsuario, "Usuario invalido, intente nuevamente.");
                Error = true;
            }
            //if (TxtCrearUsuario.Text == usuario.NombreUsuario)
            //{
            //    errorProvider1.SetError(TxtCrearUsuario, "Usuario invalido, intente nuevamente.");
            //    Error = true;
            //}

            return Error;
        }

    }
}
