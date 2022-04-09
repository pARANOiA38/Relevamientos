
namespace IncidenciasProyect
{
    partial class Incidencia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grilla = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxFecha = new System.Windows.Forms.CheckBox();
            this.checkBoxResponsable = new System.Windows.Forms.CheckBox();
            this.checkBoxDependencia = new System.Windows.Forms.CheckBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.boxFiltroResp = new System.Windows.Forms.ComboBox();
            this.boxFiltroDepen = new System.Windows.Forms.ComboBox();
            this.boxFiltroEstado = new System.Windows.Forms.ComboBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtDependencia = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.boxResponsable = new System.Windows.Forms.ComboBox();
            this.boxSucursal = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.AllowUserToResizeColumns = false;
            this.grilla.AllowUserToResizeRows = false;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.fecha,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.grilla.Location = new System.Drawing.Point(345, 12);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(744, 530);
            this.grilla.TabIndex = 0;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INCIDENCIAS";
            // 
            // chboxFecha
            // 
            this.chboxFecha.AutoSize = true;
            this.chboxFecha.Location = new System.Drawing.Point(12, 51);
            this.chboxFecha.Name = "chboxFecha";
            this.chboxFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chboxFecha.Size = new System.Drawing.Size(61, 17);
            this.chboxFecha.TabIndex = 2;
            this.chboxFecha.Text = "FECHA";
            this.chboxFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chboxFecha.UseVisualStyleBackColor = true;
            // 
            // checkBoxResponsable
            // 
            this.checkBoxResponsable.AutoSize = true;
            this.checkBoxResponsable.Location = new System.Drawing.Point(1, 284);
            this.checkBoxResponsable.Name = "checkBoxResponsable";
            this.checkBoxResponsable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxResponsable.Size = new System.Drawing.Size(105, 17);
            this.checkBoxResponsable.TabIndex = 3;
            this.checkBoxResponsable.Text = "RESPONSABLE";
            this.checkBoxResponsable.UseVisualStyleBackColor = true;
            // 
            // checkBoxDependencia
            // 
            this.checkBoxDependencia.AutoSize = true;
            this.checkBoxDependencia.Location = new System.Drawing.Point(3, 352);
            this.checkBoxDependencia.Name = "checkBoxDependencia";
            this.checkBoxDependencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxDependencia.Size = new System.Drawing.Size(103, 17);
            this.checkBoxDependencia.TabIndex = 4;
            this.checkBoxDependencia.Text = "DEPENDENCIA";
            this.checkBoxDependencia.UseVisualStyleBackColor = true;
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.Location = new System.Drawing.Point(36, 417);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEstado.Size = new System.Drawing.Size(70, 17);
            this.checkBoxEstado.TabIndex = 5;
            this.checkBoxEstado.Text = "ESTADO";
            this.checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // boxFiltroResp
            // 
            this.boxFiltroResp.Enabled = false;
            this.boxFiltroResp.FormattingEnabled = true;
            this.boxFiltroResp.Location = new System.Drawing.Point(126, 280);
            this.boxFiltroResp.Name = "boxFiltroResp";
            this.boxFiltroResp.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroResp.TabIndex = 6;
            // 
            // boxFiltroDepen
            // 
            this.boxFiltroDepen.Enabled = false;
            this.boxFiltroDepen.FormattingEnabled = true;
            this.boxFiltroDepen.Location = new System.Drawing.Point(126, 350);
            this.boxFiltroDepen.Name = "boxFiltroDepen";
            this.boxFiltroDepen.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroDepen.TabIndex = 7;
            // 
            // boxFiltroEstado
            // 
            this.boxFiltroEstado.Enabled = false;
            this.boxFiltroEstado.FormattingEnabled = true;
            this.boxFiltroEstado.Location = new System.Drawing.Point(126, 417);
            this.boxFiltroEstado.Name = "boxFiltroEstado";
            this.boxFiltroEstado.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroEstado.TabIndex = 8;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(85, 42);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1321, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1115, 562);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR ";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtDependencia
            // 
            this.txtDependencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDependencia.Location = new System.Drawing.Point(1216, 39);
            this.txtDependencia.Name = "txtDependencia";
            this.txtDependencia.Size = new System.Drawing.Size(100, 20);
            this.txtDependencia.TabIndex = 23;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(1170, 12);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(10, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "-";
            // 
            // boxResponsable
            // 
            this.boxResponsable.Enabled = false;
            this.boxResponsable.FormattingEnabled = true;
            this.boxResponsable.Items.AddRange(new object[] {
            "JAVIER",
            "EMMANUEL",
            "ALEJANDRO"});
            this.boxResponsable.Location = new System.Drawing.Point(1216, 109);
            this.boxResponsable.Name = "boxResponsable";
            this.boxResponsable.Size = new System.Drawing.Size(121, 21);
            this.boxResponsable.TabIndex = 21;
            // 
            // boxSucursal
            // 
            this.boxSucursal.Enabled = false;
            this.boxSucursal.FormattingEnabled = true;
            this.boxSucursal.Items.AddRange(new object[] {
            "PINGUINO 1",
            "PINGUINO 2",
            "PINGUINO 3",
            "PINGUINO 4",
            "PINGUINO 5",
            "PINGUINO 6",
            "PINGUINO 7",
            "PINGUINO 8",
            "PINGUINO 9",
            "ADM. CENTRAL",
            "C. PRODUCCION",
            "C. DISTRIBUCION"});
            this.boxSucursal.Location = new System.Drawing.Point(1216, 76);
            this.boxSucursal.Name = "boxSucursal";
            this.boxSucursal.Size = new System.Drawing.Size(121, 21);
            this.boxSucursal.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1112, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "RESPONSABLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1112, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "SUCURSAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1112, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "DEPENDENCIA:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(1112, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(52, 13);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "CODIGO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1112, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "OBSERVACIONES:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(1115, 185);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(271, 357);
            this.txtObservaciones.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1219, 562);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(345, 562);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(226, 23);
            this.btnGenerar.TabIndex = 25;
            this.btnGenerar.Text = "GENERAR NUEVA INCIDENCIA";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DEPENDENCIA";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SUCURSAL";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RESPONSABLE";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "OBSERVACIONES";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ESTADO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1402, 605);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.txtDependencia);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.boxResponsable);
            this.Controls.Add(this.boxSucursal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.boxFiltroEstado);
            this.Controls.Add(this.boxFiltroDepen);
            this.Controls.Add(this.boxFiltroResp);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.checkBoxDependencia);
            this.Controls.Add(this.checkBoxResponsable);
            this.Controls.Add(this.chboxFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla);
            this.Name = "Incidencia";
            this.Text = "Incidencia";
            this.Load += new System.EventHandler(this.Incidencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chboxFecha;
        private System.Windows.Forms.CheckBox checkBoxResponsable;
        private System.Windows.Forms.CheckBox checkBoxDependencia;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.ComboBox boxFiltroResp;
        private System.Windows.Forms.ComboBox boxFiltroDepen;
        private System.Windows.Forms.ComboBox boxFiltroEstado;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtDependencia;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.ComboBox boxResponsable;
        private System.Windows.Forms.ComboBox boxSucursal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}