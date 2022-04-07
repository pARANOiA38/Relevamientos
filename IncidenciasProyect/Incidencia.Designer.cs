
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(337, 12);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(769, 530);
            this.grilla.TabIndex = 0;
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
            this.chboxFecha.Location = new System.Drawing.Point(36, 78);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 280);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 350);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(126, 417);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 8;
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(126, 60);
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 9;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(1041, 562);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(65, 31);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(337, 562);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(164, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "AGREGAR INCIDENCIA";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Incidencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 605);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.MonthCalendar calendario;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregar;
    }
}