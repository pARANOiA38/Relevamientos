﻿
namespace IncidenciasProyect
{
    partial class Logueo
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
            this.btnEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIncidencias = new System.Windows.Forms.Button();
            this.btnDesloguearse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(166, 191);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CONTRASEÑA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "INGRESO";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(155, 93);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 4;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(155, 145);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(356, 336);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(32, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIncidencias
            // 
            this.btnIncidencias.Location = new System.Drawing.Point(159, 264);
            this.btnIncidencias.Name = "btnIncidencias";
            this.btnIncidencias.Size = new System.Drawing.Size(87, 23);
            this.btnIncidencias.TabIndex = 7;
            this.btnIncidencias.Text = "INCIDENCIAS";
            this.btnIncidencias.UseVisualStyleBackColor = true;
            this.btnIncidencias.Click += new System.EventHandler(this.btnIncidencias_Click);
            // 
            // btnDesloguearse
            // 
            this.btnDesloguearse.Location = new System.Drawing.Point(12, 336);
            this.btnDesloguearse.Name = "btnDesloguearse";
            this.btnDesloguearse.Size = new System.Drawing.Size(83, 23);
            this.btnDesloguearse.TabIndex = 8;
            this.btnDesloguearse.Text = "Desloguearse";
            this.btnDesloguearse.UseVisualStyleBackColor = true;
            this.btnDesloguearse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Logueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(400, 371);
            this.Controls.Add(this.btnDesloguearse);
            this.Controls.Add(this.btnIncidencias);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEntrar);
            this.MaximizeBox = false;
            this.Name = "Logueo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo";
            this.Load += new System.EventHandler(this.Logueo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIncidencias;
        private System.Windows.Forms.Button btnDesloguearse;
    }
}