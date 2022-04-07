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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                        
            string dependencia = txtDependencia.Text;
            string observacion = txtObservaciones.Text;
            string sucursal = boxSucursal.Text;
            string responsable = boxResponsable.Text;

            formInterfaz.AgregarIncidencia(observacion, dependencia, sucursal, responsable);
            formInterfaz.GuardarIncidencias();
            
            this.Close();
            

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                int cod = formInterfaz.DevolverCod();
                lblCodigo.Text = cod.ToString();              
            }
        }
    }
}
