using System;
using System.Collections.Generic;
using System.Text;

namespace Evaluacion4_BE
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public void Agregar(string aNombreUsuario, string aContrasena)
        {
            NombreUsuario = aNombreUsuario;
            Contrasena = aContrasena;
        }
    }
}
