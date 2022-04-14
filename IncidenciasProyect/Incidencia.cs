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

        private void CargarGrilla(Problema item)
        {
            int n = grilla.Rows.Add();

            grilla.Rows[n].Cells[0].Value = item.cod;
            grilla.Rows[n].Cells[1].Value = item.FechaHoy;
            grilla.Rows[n].Cells[2].Value = item.dependencia;
            grilla.Rows[n].Cells[3].Value = item.sucursal;
            grilla.Rows[n].Cells[4].Value = item.responsable;
            grilla.Rows[n].Cells[5].Value = item.observacion;
            grilla.Rows[n].Cells[6].Value = item.estado;

            if (item.estado == "PENDIENTE")
            {
                grilla.Rows[n].Cells[6].Style.BackColor = Color.Red;

            }
            else
            {
                grilla.Rows[n].Cells[6].Style.BackColor = Color.Green;
            }
        }
        private void Incidencia_Load(object sender, EventArgs e)
        {
            btnCancelar.Enabled = false;
            btnHabilitarModificacion.Enabled = false;
            txtDependencia.Enabled = false;
            txtObservaciones.Enabled = false;
            boxResponsable.Enabled = false;
            boxSucursal.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            btnCambiarEstado.Enabled = false;

            List<Problema> nuevaListaProblema = new List<Problema>();

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                nuevaListaProblema = formInterfaz.ObtenerProblemas();

                foreach (var item in nuevaListaProblema)
                {

                    CargarGrilla(item);

                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<Problema> nuevaListaProblema = new List<Problema>();

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                if (txtDependencia.Text != "" && txtObservaciones.Text != "" && boxResponsable.Text != "" && boxSucursal.Text != "")
                {
                    formInterfaz.AgregarIncidencia(txtObservaciones.Text, txtDependencia.Text, boxSucursal.Text, boxResponsable.Text);
                    formInterfaz.GuardarIncidencias();

                    nuevaListaProblema = formInterfaz.ObtenerProblemas();

                    grilla.Rows.Clear();

                    foreach (var item in nuevaListaProblema)
                    {

                        CargarGrilla(item);

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
                else
                {
                    MessageBox.Show("Uno o mas campos no se encuentran ingresados", "Error de datos");
                }
            }

            grilla.Enabled = true;
            btnCancelar.Enabled = false;
            btnCambiarEstado.Enabled = false;
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            grilla.Enabled = false;

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                formInterfaz.LeerArchivosTXT();

                txtDependencia.Text = "";
                txtObservaciones.Text = "";
                boxResponsable.Text = "";
                boxSucursal.Text = "";
                lblCodigo.Text = "-";
                lblestado.Text = "-";
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
            if (e.RowIndex != -1)
            {
                btnHabilitarModificacion.Enabled = true;
                var row = grilla.Rows[e.RowIndex];


                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {

                    Problema problemaSeleccionado = row.DataBoundItem as Problema;

                    int indice = grilla.CurrentCell.RowIndex;

                    lblCodigo.Text = (string)grilla.Rows[indice].Cells[0].Value.ToString();
                    txtDependencia.Text = (string)grilla.Rows[indice].Cells[2].Value; ;
                    txtObservaciones.Text = (string)grilla.Rows[indice].Cells[5].Value; ;
                    boxResponsable.Text = (string)grilla.Rows[indice].Cells[4].Value; ;
                    boxSucursal.Text = (string)grilla.Rows[indice].Cells[3].Value;
                    lblestado.Text = (string)grilla.Rows[indice].Cells[6].Value;

                }
            }
            
          
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grilla_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var row = grilla.Rows[e.RowIndex];
                var column = grilla.Columns[e.ColumnIndex];
                List<Problema> nuevaListaProblemas = new List<Problema>();


                if (column.Name == "Eliminar")
                {
                    var mensaje = MessageBox.Show("Está seguro que desea eliminar la incidencia?", "Eliminar jugador", MessageBoxButtons.OKCancel);

                    if (mensaje == DialogResult.OK)
                    {
                        IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                        if (formInterfaz != null)
                        {
                            Problema JugadorSeleccionado = row.DataBoundItem as Problema;

                            int indice = grilla.CurrentCell.RowIndex;

                            int cod = (int)grilla.Rows[indice].Cells[0].Value;

                            formInterfaz.EliminarIncidencia(cod);

                            formInterfaz.ReordenarCodigo();

                            formInterfaz.GuardarIncidencias();

                            grilla.Rows.Clear();

                            nuevaListaProblemas = formInterfaz.ObtenerProblemas();

                            foreach (var item in nuevaListaProblemas)
                            {

                                CargarGrilla(item);

                            }

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
                        lblestado.Text = "-";
                        btnGenerar.Enabled = true;
                    }
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblestado.Text == "PENDIENTE")
            {
                lblestado.Text = "REPARADO";
            }
            else
            {
                lblestado.Text = "PENDIENTE";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {           
            List<Problema> nuevaListaProblema = new List<Problema>();
            txtDependencia.Enabled = true;
            txtObservaciones.Enabled = true;
            boxResponsable.Enabled = true;
            boxSucursal.Enabled = true;
            btnGenerar.Enabled = false;

            if (txtDependencia.Text != "" && txtObservaciones.Text != "" && boxResponsable.Text != "" && boxSucursal.Text != "")
            {

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    formInterfaz.LeerArchivosTXT();

                    int cod = Int32.Parse(lblCodigo.Text);

                    formInterfaz.ModificarIncidencia(cod, txtObservaciones.Text, txtDependencia.Text, boxSucursal.Text, lblestado.Text, boxResponsable.Text);

                    formInterfaz.GuardarIncidencias();

                    nuevaListaProblema = formInterfaz.ObtenerProblemas();

                    grilla.Rows.Clear();

                    foreach (var item in nuevaListaProblema)
                    {

                        CargarGrilla(item);

                    }
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
                lblestado.Text = "-";
                btnGenerar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Uno o mas campos no se encuentran ingresados", "Error de datos");
            }

            btnCambiarEstado.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnCambiarEstado.Enabled = true;
            btnHabilitarModificacion.Enabled = false;
            btnModificar.Enabled = true;
            txtDependencia.Enabled = true;
            txtObservaciones.Enabled = true;
            boxResponsable.Enabled = true;
            boxSucursal.Enabled = true;
        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            string fecha = calendario.SelectionStart.ToString("dd/MM/yyyy");
                  
            txtFecha.Text = fecha;
                     
        }

        private void checkBoxResponsable_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBoxResponsable.Checked == true && boxFiltroResp.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxEstado.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxSucursal.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.responsable == boxFiltroResp.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxResponsable.Checked == false)
                {
                    boxFiltroResp.Text = "";
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxEstado.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxSucursal.Enabled = true;
                }

            }
        }

        private void checkBoxSucursal_CheckedChanged(object sender, EventArgs e)
        {
           

            if (checkBoxSucursal.Checked == true && boxFiltroSucursal.Text != "")
            {

                grilla.Rows.Clear();
                checkBoxEstado.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.sucursal == boxFiltroSucursal.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxSucursal.Checked == false)
                {
                    boxFiltroSucursal.Text = "";
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxEstado.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }
        }

        private void checkBoxEstado_CheckedChanged(object sender, EventArgs e)
        {         
            if (checkBoxEstado.Checked == true && boxFiltroEstado.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxSucursal.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.estado == boxFiltroEstado.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxEstado.Checked == false)
                {
                    boxFiltroEstado.Text = "";
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxSucursal.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }
        }

        private void chboxFecha_CheckedChanged(object sender, EventArgs e)
        {           
            if (chboxFecha.Checked == true && txtFecha.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxSucursal.Enabled = false;
                checkBoxEstado.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.FechaHoy == txtFecha.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (chboxFecha.Checked == false)
                {
                    txtFecha.Text = "";
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxSucursal.Enabled = true;
                    checkBoxEstado.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }
        }

        private void boxFiltroResp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxResponsable.Checked == true && boxFiltroResp.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxEstado.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxSucursal.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.responsable == boxFiltroResp.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxResponsable.Checked == false)
                {
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxEstado.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxSucursal.Enabled = true;
                }

            }

        }

        private void txtFecha_TextChanged(object sender, EventArgs e)
        {
            if (chboxFecha.Checked == true && txtFecha.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxSucursal.Enabled = false;
                checkBoxEstado.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.FechaHoy == txtFecha.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (chboxFecha.Checked == false)
                {
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxSucursal.Enabled = true;
                    checkBoxEstado.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }

        }

        private void boxFiltroSucursal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBoxSucursal.Checked == true && boxFiltroSucursal.Text != "")
            {

                grilla.Rows.Clear();
                checkBoxEstado.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.sucursal == boxFiltroSucursal.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxSucursal.Checked == false)
                {
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxEstado.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }

        }

        private void boxFiltroEstado_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (checkBoxEstado.Checked == true && boxFiltroEstado.Text != "")
            {
                grilla.Rows.Clear();

                checkBoxSucursal.Enabled = false;
                chboxFecha.Enabled = false;
                checkBoxResponsable.Enabled = false;

                IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                if (formInterfaz != null)
                {
                    List<Problema> listFiltrada = formInterfaz.ObtenerProblemas();

                    foreach (var item in listFiltrada)
                    {
                        if (item.estado == boxFiltroEstado.Text)
                        {
                            CargarGrilla(item);
                        }
                    }
                }
            }
            else
            {
                if (checkBoxEstado.Checked == false)
                {
                    grilla.Rows.Clear();

                    IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
                    if (formInterfaz != null)
                    {
                        List<Problema> listNormal = formInterfaz.ObtenerProblemas();

                        foreach (var item in listNormal)
                        {
                            CargarGrilla(item);
                        }
                    }

                    checkBoxSucursal.Enabled = true;
                    chboxFecha.Enabled = true;
                    checkBoxResponsable.Enabled = true;
                }
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            grilla.Enabled = true;

            txtDependencia.Enabled = false;
            txtObservaciones.Enabled = false;
            boxResponsable.Enabled = false;
            boxSucursal.Enabled = false;
            btnModificar.Enabled = false;
            btnAgregar.Enabled = false;
            txtDependencia.Text = "";
            txtObservaciones.Text = "";          
            lblCodigo.Text = "-";
            lblestado.Text = "-";
            btnGenerar.Enabled = true;

            btnCancelar.Enabled = false;
            btnCambiarEstado.Enabled = false;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            grilla.Rows.Clear();

            List<Problema> nuevaListaProblemas = new List<Problema>();

            IFuncionesYmetodosUsuario formInterfaz = this.Owner as IFuncionesYmetodosUsuario;
            if (formInterfaz != null)
            {
                formInterfaz.LeerArchivosTXT();

                nuevaListaProblemas = formInterfaz.ObtenerProblemas();

                foreach (var item in nuevaListaProblemas)
                {

                    CargarGrilla(item);

                }
            }
        }
    }
}
