
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incidencia));
            this.grilla = new System.Windows.Forms.DataGridView();
            this.CODIGO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.chboxFecha = new System.Windows.Forms.CheckBox();
            this.checkBoxResponsable = new System.Windows.Forms.CheckBox();
            this.checkBoxSucursal = new System.Windows.Forms.CheckBox();
            this.checkBoxEstado = new System.Windows.Forms.CheckBox();
            this.boxFiltroResp = new System.Windows.Forms.ComboBox();
            this.boxFiltroSucursal = new System.Windows.Forms.ComboBox();
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
            this.lblestado = new System.Windows.Forms.Label();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.btnHabilitarModificacion = new System.Windows.Forms.Button();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chboxDependencia = new System.Windows.Forms.CheckBox();
            this.txtFiltroDependencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.AllowUserToAddRows = false;
            this.grilla.AllowUserToDeleteRows = false;
            this.grilla.AllowUserToResizeColumns = false;
            this.grilla.AllowUserToResizeRows = false;
            this.grilla.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CODIGO,
            this.fecha,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Eliminar});
            this.grilla.Location = new System.Drawing.Point(264, 12);
            this.grilla.Name = "grilla";
            this.grilla.ReadOnly = true;
            this.grilla.Size = new System.Drawing.Size(845, 530);
            this.grilla.TabIndex = 0;
            this.grilla.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick);
            this.grilla.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grilla_CellContentClick_1);
            // 
            // CODIGO
            // 
            this.CODIGO.HeaderText = "CODIGO";
            this.CODIGO.Name = "CODIGO";
            this.CODIGO.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DEPENDENCIA";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SUCURSAL";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "RESPONSABLE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "OBSERVACIONES";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column5.HeaderText = "ESTADO";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseColumnTextForLinkValue = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(59, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "INCIDENCIAS";
            // 
            // chboxFecha
            // 
            this.chboxFecha.AutoSize = true;
            this.chboxFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chboxFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxFecha.Location = new System.Drawing.Point(41, 74);
            this.chboxFecha.Name = "chboxFecha";
            this.chboxFecha.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chboxFecha.Size = new System.Drawing.Size(74, 19);
            this.chboxFecha.TabIndex = 2;
            this.chboxFecha.Text = ":FECHA";
            this.chboxFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chboxFecha.UseVisualStyleBackColor = false;
            this.chboxFecha.CheckedChanged += new System.EventHandler(this.chboxFecha_CheckedChanged);
            // 
            // checkBoxResponsable
            // 
            this.checkBoxResponsable.AutoSize = true;
            this.checkBoxResponsable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxResponsable.Location = new System.Drawing.Point(3, 296);
            this.checkBoxResponsable.Name = "checkBoxResponsable";
            this.checkBoxResponsable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxResponsable.Size = new System.Drawing.Size(130, 19);
            this.checkBoxResponsable.TabIndex = 3;
            this.checkBoxResponsable.Text = ":RESPONSABLE";
            this.checkBoxResponsable.UseVisualStyleBackColor = false;
            this.checkBoxResponsable.CheckedChanged += new System.EventHandler(this.checkBoxResponsable_CheckedChanged);
            // 
            // checkBoxSucursal
            // 
            this.checkBoxSucursal.AutoSize = true;
            this.checkBoxSucursal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxSucursal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSucursal.Location = new System.Drawing.Point(29, 342);
            this.checkBoxSucursal.Name = "checkBoxSucursal";
            this.checkBoxSucursal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxSucursal.Size = new System.Drawing.Size(103, 19);
            this.checkBoxSucursal.TabIndex = 4;
            this.checkBoxSucursal.Text = ":SUCURSAL";
            this.checkBoxSucursal.UseVisualStyleBackColor = false;
            this.checkBoxSucursal.CheckedChanged += new System.EventHandler(this.checkBoxSucursal_CheckedChanged);
            // 
            // checkBoxEstado
            // 
            this.checkBoxEstado.AutoSize = true;
            this.checkBoxEstado.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.checkBoxEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEstado.Location = new System.Drawing.Point(48, 383);
            this.checkBoxEstado.Name = "checkBoxEstado";
            this.checkBoxEstado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxEstado.Size = new System.Drawing.Size(84, 19);
            this.checkBoxEstado.TabIndex = 5;
            this.checkBoxEstado.Text = ":ESTADO";
            this.checkBoxEstado.UseVisualStyleBackColor = false;
            this.checkBoxEstado.CheckedChanged += new System.EventHandler(this.checkBoxEstado_CheckedChanged);
            // 
            // boxFiltroResp
            // 
            this.boxFiltroResp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFiltroResp.FormattingEnabled = true;
            this.boxFiltroResp.Items.AddRange(new object[] {
            "JAVIER",
            "EMMANUEL",
            "ALEJANDRO"});
            this.boxFiltroResp.Location = new System.Drawing.Point(139, 295);
            this.boxFiltroResp.Name = "boxFiltroResp";
            this.boxFiltroResp.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroResp.TabIndex = 6;
            this.boxFiltroResp.SelectedIndexChanged += new System.EventHandler(this.boxFiltroResp_SelectedIndexChanged);
            // 
            // boxFiltroSucursal
            // 
            this.boxFiltroSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFiltroSucursal.FormattingEnabled = true;
            this.boxFiltroSucursal.Items.AddRange(new object[] {
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
            this.boxFiltroSucursal.Location = new System.Drawing.Point(139, 340);
            this.boxFiltroSucursal.Name = "boxFiltroSucursal";
            this.boxFiltroSucursal.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroSucursal.TabIndex = 7;
            this.boxFiltroSucursal.SelectedIndexChanged += new System.EventHandler(this.boxFiltroSucursal_SelectedIndexChanged);
            // 
            // boxFiltroEstado
            // 
            this.boxFiltroEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxFiltroEstado.FormattingEnabled = true;
            this.boxFiltroEstado.Items.AddRange(new object[] {
            "PENDIENTE",
            "ESPERA",
            "REPARADO"});
            this.boxFiltroEstado.Location = new System.Drawing.Point(139, 383);
            this.boxFiltroEstado.Name = "boxFiltroEstado";
            this.boxFiltroEstado.Size = new System.Drawing.Size(121, 21);
            this.boxFiltroEstado.TabIndex = 8;
            this.boxFiltroEstado.SelectedIndexChanged += new System.EventHandler(this.boxFiltroEstado_SelectedIndexChanged);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(8, 105);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 9;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1422, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(1118, 562);
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
            this.txtDependencia.Location = new System.Drawing.Point(1238, 40);
            this.txtDependencia.Name = "txtDependencia";
            this.txtDependencia.Size = new System.Drawing.Size(100, 20);
            this.txtDependencia.TabIndex = 23;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(1188, 13);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(11, 13);
            this.lblCodigo.TabIndex = 22;
            this.lblCodigo.Text = "-";
            // 
            // boxResponsable
            // 
            this.boxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boxResponsable.Enabled = false;
            this.boxResponsable.FormattingEnabled = true;
            this.boxResponsable.Items.AddRange(new object[] {
            "JAVIER",
            "EMMANUEL",
            "ALEJANDRO"});
            this.boxResponsable.Location = new System.Drawing.Point(1238, 106);
            this.boxResponsable.Name = "boxResponsable";
            this.boxResponsable.Size = new System.Drawing.Size(121, 21);
            this.boxResponsable.TabIndex = 21;
            // 
            // boxSucursal
            // 
            this.boxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.boxSucursal.Location = new System.Drawing.Point(1238, 75);
            this.boxSucursal.Name = "boxSucursal";
            this.boxSucursal.Size = new System.Drawing.Size(121, 21);
            this.boxSucursal.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1117, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "RESPONSABLE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1116, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "SUCURSAL:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1115, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "DEPENDENCIA:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(1115, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(64, 15);
            this.lbl.TabIndex = 16;
            this.lbl.Text = "CODIGO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1117, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "OBSERVACIONES:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(1118, 207);
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(351, 343);
            this.txtObservaciones.TabIndex = 14;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(1318, 562);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(98, 23);
            this.btnModificar.TabIndex = 24;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(264, 562);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(226, 23);
            this.btnGenerar.TabIndex = 25;
            this.btnGenerar.Text = "GENERAR NUEVA INCIDENCIA";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblestado
            // 
            this.lblestado.AutoSize = true;
            this.lblestado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblestado.Location = new System.Drawing.Point(1238, 150);
            this.lblestado.Name = "lblestado";
            this.lblestado.Size = new System.Drawing.Size(11, 13);
            this.lblestado.TabIndex = 26;
            this.lblestado.Text = "-";
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(1115, 145);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(117, 23);
            this.btnCambiarEstado.TabIndex = 27;
            this.btnCambiarEstado.Text = "CAMBIAR ESTADO";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHabilitarModificacion
            // 
            this.btnHabilitarModificacion.Location = new System.Drawing.Point(883, 562);
            this.btnHabilitarModificacion.Name = "btnHabilitarModificacion";
            this.btnHabilitarModificacion.Size = new System.Drawing.Size(226, 23);
            this.btnHabilitarModificacion.TabIndex = 28;
            this.btnHabilitarModificacion.Text = "HABILITAR MODIFICACIÓN";
            this.btnHabilitarModificacion.UseVisualStyleBackColor = true;
            this.btnHabilitarModificacion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtFecha
            // 
            this.txtFecha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFecha.Location = new System.Drawing.Point(131, 74);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.ReadOnly = true;
            this.txtFecha.Size = new System.Drawing.Size(121, 20);
            this.txtFecha.TabIndex = 29;
            this.txtFecha.TextChanged += new System.EventHandler(this.txtFecha_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1222, 562);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 23);
            this.btnCancelar.TabIndex = 30;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "ACTUALIZAR LISTA ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // chboxDependencia
            // 
            this.chboxDependencia.AutoSize = true;
            this.chboxDependencia.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.chboxDependencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chboxDependencia.Location = new System.Drawing.Point(5, 427);
            this.chboxDependencia.Name = "chboxDependencia";
            this.chboxDependencia.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chboxDependencia.Size = new System.Drawing.Size(127, 19);
            this.chboxDependencia.TabIndex = 32;
            this.chboxDependencia.Text = ":DEPENDENCIA";
            this.chboxDependencia.UseVisualStyleBackColor = false;
            this.chboxDependencia.CheckedChanged += new System.EventHandler(this.chboxDependencia_CheckedChanged);
            // 
            // txtFiltroDependencia
            // 
            this.txtFiltroDependencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtFiltroDependencia.Location = new System.Drawing.Point(139, 427);
            this.txtFiltroDependencia.Name = "txtFiltroDependencia";
            this.txtFiltroDependencia.Size = new System.Drawing.Size(121, 20);
            this.txtFiltroDependencia.TabIndex = 33;
            this.txtFiltroDependencia.TextChanged += new System.EventHandler(this.txtFiltroDependencia_TextChanged);
            // 
            // Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = global::IncidenciasProyect.Properties.Resources.backgroundAPP;
            this.ClientSize = new System.Drawing.Size(1481, 605);
            this.Controls.Add(this.txtFiltroDependencia);
            this.Controls.Add(this.chboxDependencia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.btnHabilitarModificacion);
            this.Controls.Add(this.btnCambiarEstado);
            this.Controls.Add(this.lblestado);
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
            this.Controls.Add(this.boxFiltroSucursal);
            this.Controls.Add(this.boxFiltroResp);
            this.Controls.Add(this.checkBoxEstado);
            this.Controls.Add(this.checkBoxSucursal);
            this.Controls.Add(this.checkBoxResponsable);
            this.Controls.Add(this.chboxFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grilla);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
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
        private System.Windows.Forms.CheckBox checkBoxSucursal;
        private System.Windows.Forms.CheckBox checkBoxEstado;
        private System.Windows.Forms.ComboBox boxFiltroResp;
        private System.Windows.Forms.ComboBox boxFiltroSucursal;
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
        private System.Windows.Forms.Label lblestado;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.Button btnHabilitarModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CODIGO;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chboxDependencia;
        private System.Windows.Forms.TextBox txtFiltroDependencia;
    }
}