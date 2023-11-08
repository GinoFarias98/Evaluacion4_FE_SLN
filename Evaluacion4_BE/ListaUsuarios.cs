using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Xml.Schema;

namespace Evaluacion4_BE
{
    public class ListaUsuarios
    {

        public DataTable ListadorUsuariosDT { get; set; } = new DataTable();

        public ListaUsuarios()
        {
            ListadorUsuariosDT.TableName = "Usuarios-Registrados";
            ListadorUsuariosDT.Columns.Add("Codigo", typeof(int));
            ListadorUsuariosDT.Columns.Add("Usuario");
            ListadorUsuariosDT.Columns.Add("Contraseña");
            Lector();
        }

        public void Lector()
        {
            if (System.IO.File.Exists("Usuarios-Registrados.xml"))
            {
                ListadorUsuariosDT.ReadXml("Usuarios-Registrados.xml");
            }
        }

        public void InsertUsuario(Usuario aUsuario)
        {
            int Codigo = NuevoCod();

            ListadorUsuariosDT.Rows.Add(); 
            int NuevoRenglon = ListadorUsuariosDT.Rows.Count - 1;
            ListadorUsuariosDT.Rows[NuevoRenglon]["Codigo"] = Codigo;
            ListadorUsuariosDT.Rows[NuevoRenglon]["Usuario"] = aUsuario.NombreUsuario;
            ListadorUsuariosDT.Rows[NuevoRenglon]["Contraseña"] = aUsuario.Contrasena;

            ListadorUsuariosDT.WriteXml("Usuarios-Registrados.xml");
        }

        private int NuevoCod()
        {
            int Nuevocod = 0;

            foreach (DataRow fila in ListadorUsuariosDT.Rows)
            {
                if (Nuevocod < Convert.ToInt32(fila["Codigo"]))
                {
                    Nuevocod = Convert.ToInt32(fila["Codigo"]);
                }
            }

            Nuevocod++;
            return Nuevocod;
        }

        
        public Usuario BuscarUsuario(string aNombreUsuario)
        {
            string NombreUsuario = aNombreUsuario;
            Usuario UsuarioLista = new Usuario();

            foreach (DataRow fila in ListadorUsuariosDT.Rows)
            {
                if (fila["Usuario"].ToString() == NombreUsuario)
                {
                    //UsuarioLista.NombreUsuario = Convert.ToString(fila["Usuario"]);
                    UsuarioLista.Codigo = (Convert.ToInt32(fila["Codigo"]));
                    UsuarioLista.NombreUsuario = (fila["Usuario"].ToString());
                    UsuarioLista.Contrasena = (fila["Contraseña"].ToString());
                    break;
                }
            }
            

            return UsuarioLista;
        }

        public Usuario BuscarContrasena(string aUsuario, string aContrasena)
        {
            string Usuario = aUsuario;
            string contrasena = aContrasena;
            Usuario ContraseñaLista = new Usuario();

            foreach (DataRow fila in ListadorUsuariosDT.Rows)
            {
                if (fila["Usuario"].ToString() == Usuario & fila["Contraseña"].ToString() == contrasena)
                {
                    ContraseñaLista.Codigo = (Convert.ToInt32(fila["Codigo"]));
                    ContraseñaLista.NombreUsuario = (fila["Usuario"].ToString());
                    ContraseñaLista.Contrasena = (fila["Contraseña"].ToString());
                    break;
                }
            }


            return ContraseñaLista;
        }

    }
}
