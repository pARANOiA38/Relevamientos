using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicaIncidencias;

namespace IncidenciasProyect
{
    public partial class Logueo : Form, IFuncionesYmetodosUsuario
    {
        public ClasePrincipal nuevaClasePrincipal { get; set; }
        public Logueo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Logueo_Load(object sender, EventArgs e)
        {
            btnIncidencias.Visible = false;
            this.nuevaClasePrincipal = new ClasePrincipal();           

            nuevaClasePrincipal.Usuarios = new List<Usuario>();
            nuevaClasePrincipal.Problemas = new List<Problema>();

            nuevaClasePrincipal.GenerarArchivosTXT();

            nuevaClasePrincipal.LeerArchivosTXT();

            Usuario nuevouser = new Usuario();

            nuevouser.user = "javier";
            nuevouser.pass = "comini";

            nuevaClasePrincipal.Usuarios.Add(nuevouser);

            nuevaClasePrincipal.GuardarUsuarios();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtContraseña.Text == "" | txtUsuario.Text == "")
            {

                MessageBox.Show("Escriba un email y clave", "Error de usuario");

            }
            else
            {

                if (nuevaClasePrincipal.Usuarios == null)
                {
                    MessageBox.Show("No hay usuarios cargados en el sistema", "Error de usuario");
                }
                else
                {

                    string email = txtUsuario.Text;
                    string clave = txtContraseña.Text;

                    bool CondicionFinal = ValidarUsuario(email, clave);

                    if (CondicionFinal == false)
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta", "Error de credenciales");
                    }
                    else
                    {
                        btnIncidencias.Visible = true;
                        txtContraseña.Enabled = false;
                        txtUsuario.Enabled = false;
                        txtContraseña.Text = "";
                        txtUsuario.Text = "";
                        btnEntrar.Enabled = false;
                    }
                }
            }
        }

        public void AgregarIncidencia(string observacion, string dependencia, string sucursal, string responsable)
        {
            nuevaClasePrincipal.AgregarIncidencia(observacion, dependencia, sucursal, responsable);
        }
        public void EliminarIncidencia(int cod)
        {
            nuevaClasePrincipal.EliminarIncidencia(cod);
        }
        public void ModificarIncidencia(int cod, string observacion, string dependencia, string sucursal, string estado, string responsable)
        {
            nuevaClasePrincipal.ModificarIncidencia(cod, observacion, dependencia, sucursal, estado, responsable);
        }
        public void CambiarEstado(int cod, string estado)
        {
            nuevaClasePrincipal.CambiarEstado(cod, estado);
        }
        public int DevolverCod()
        {
            return nuevaClasePrincipal.DevolverCod();
        }
        public bool ValidarUsuario(string user, string pass)
        {
            return nuevaClasePrincipal.ValidarUsuario(user, pass);
        }
        public void LeerArchivosTXT()
        {
            nuevaClasePrincipal.LeerArchivosTXT();
        }
        public void GuardarIncidencias()
        {
            nuevaClasePrincipal.GuardarIncidencias();
        }

        public List<Problema> ObtenerProblemas()
        {
            return nuevaClasePrincipal.ObtenerProblemas();
        }

        private void btnIncidencias_Click(object sender, EventArgs e)
        {
            Incidencia nuevoIncidencia = new Incidencia();
            nuevoIncidencia.Owner = this;
            nuevoIncidencia.ShowDialog();
        }
    }
}
