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
            txtDependencia.Enabled = false;
            txtObservaciones.Enabled = false;
            boxResponsable.Enabled = false;
            boxSucursal.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;

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
            List<Problema> nuevaListaProblema = new List<Problema>();

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                if (txtDependencia.Text != null && txtObservaciones.Text != null && boxResponsable.Text != null && boxSucursal.Text != null)
                {
                    formInterfaz.AgregarIncidencia(txtObservaciones.Text, txtDependencia.Text, boxSucursal.Text, boxResponsable.Text);
                    formInterfaz.GuardarIncidencias();

                    nuevaListaProblema = formInterfaz.ObtenerProblemas();

                    grilla.Rows.Clear();

                    foreach (var item in nuevaListaProblema)
                    {

                        int n = grilla.Rows.Add();

                        grilla.Rows[n].Cells[0].Value = item.cod;
                        grilla.Rows[n].Cells[1].Value = item.FechaHoy;
                        grilla.Rows[n].Cells[2].Value = item.dependencia;
                        grilla.Rows[n].Cells[3].Value = item.sucursarl;
                        grilla.Rows[n].Cells[4].Value = item.responsable;
                        grilla.Rows[n].Cells[5].Value = item.observacion;

                    }

                    txtDependencia.Enabled = false;
                    txtObservaciones.Enabled = false;
                    boxResponsable.Enabled = false;
                    boxSucursal.Enabled = false;
                    btnModificar.Enabled = false;
                    btnAgregar.Enabled = false;
                    txtDependencia.Text = "";
                    txtObservaciones.Text = "";
                    boxResponsable.Text = "";
                    boxSucursal.Text = "";
                    lblCodigo.Text = "-";
                    btnGenerar.Enabled = true;

                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                lblCodigo.Text = formInterfaz.DevolverCod().ToString();
                txtDependencia.Enabled = true;
                txtObservaciones.Enabled = true;
                boxResponsable.Enabled = true;
                boxSucursal.Enabled = true;
                btnGenerar.Enabled = false;
                btnAgregar.Enabled = true;
            }
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            var row = grilla.Rows[e.RowIndex];
            
            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                Problema problemaSeleccionado = row.DataBoundItem as Problema;

                lblCodigo.Text = problemaSeleccionado.cod.ToString();
                txtDependencia.Text = problemaSeleccionado.dependencia;
                txtObservaciones.Text = problemaSeleccionado.observacion;
                boxResponsable.Text = problemaSeleccionado.responsable;
                boxSucursal.Text = problemaSeleccionado.sucursarl;
            }
        }
    }
}
