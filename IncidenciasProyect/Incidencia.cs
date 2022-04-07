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
    public partial class Incidencia : Form
    {
        public Incidencia()
        {
            InitializeComponent();
        }

        private void Incidencia_Load(object sender, EventArgs e)
        {
            List<Problema> nuevaListaProblema = new List<Problema>();

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                nuevaListaProblema = formInterfaz.ObtenerProblemas();

                foreach (var item in nuevaListaProblema)
                {

                    int n = grilla.Rows.Add();

                    grilla.Rows[n].Cells[0].Value = item.cod;
                    grilla.Rows[n].Cells[1].Value = item.sucursarl;
                    grilla.Rows[n].Cells[2].Value = item.dependencia;
                    grilla.Rows[n].Cells[3].Value = item.estado;
                    grilla.Rows[n].Cells[4].Value = item.FechaHoy;
                    grilla.Rows[n].Cells[3].Value = item.responsable;

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Menu nuevoMenu = new Menu();
            nuevoMenu.Owner = this;
            nuevoMenu.ShowDialog();
        }
    }
}
