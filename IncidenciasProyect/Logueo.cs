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
    public partial class Logueo : Form
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
            this.nuevaClasePrincipal = new ClasePrincipal();



            nuevaClasePrincipal.Usuarios = new List<Usuario>();
            nuevaClasePrincipal.Incidencias = new List<Incidencia>();

            nuevaClasePrincipal.GenerarArchivosTXT();

            nuevaClasePrincipal.LeerArchivosTXT();
        }
    }
}
