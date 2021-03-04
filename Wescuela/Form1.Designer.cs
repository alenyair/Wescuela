namespace Wescuela
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbTipoPersona = new System.Windows.Forms.GroupBox();
            this.rdoEstudiante = new System.Windows.Forms.RadioButton();
            this.rdoProfesor = new System.Windows.Forms.RadioButton();
            this.grbDatospersona = new System.Windows.Forms.GroupBox();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnCapturarDatos = new System.Windows.Forms.Button();
            this.btnMostrarDatos = new System.Windows.Forms.Button();
            this.grbTipoPersona.SuspendLayout();
            this.grbDatospersona.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTipoPersona
            // 
            this.grbTipoPersona.Controls.Add(this.rdoEstudiante);
            this.grbTipoPersona.Controls.Add(this.rdoProfesor);
            this.grbTipoPersona.Location = new System.Drawing.Point(123, 66);
            this.grbTipoPersona.Name = "grbTipoPersona";
            this.grbTipoPersona.Size = new System.Drawing.Size(258, 140);
            this.grbTipoPersona.TabIndex = 0;
            this.grbTipoPersona.TabStop = false;
            this.grbTipoPersona.Text = "Tipo de persona";
            // 
            // rdoEstudiante
            // 
            this.rdoEstudiante.AutoSize = true;
            this.rdoEstudiante.Location = new System.Drawing.Point(0, 91);
            this.rdoEstudiante.Name = "rdoEstudiante";
            this.rdoEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rdoEstudiante.TabIndex = 1;
            this.rdoEstudiante.TabStop = true;
            this.rdoEstudiante.Text = "&Estudiante";
            this.rdoEstudiante.UseVisualStyleBackColor = true;
            this.rdoEstudiante.CheckedChanged += new System.EventHandler(this.rdoEstudiante_CheckedChanged);
            // 
            // rdoProfesor
            // 
            this.rdoProfesor.AutoSize = true;
            this.rdoProfesor.Location = new System.Drawing.Point(0, 44);
            this.rdoProfesor.Name = "rdoProfesor";
            this.rdoProfesor.Size = new System.Drawing.Size(64, 17);
            this.rdoProfesor.TabIndex = 0;
            this.rdoProfesor.TabStop = true;
            this.rdoProfesor.Text = "&Profesor";
            this.rdoProfesor.UseVisualStyleBackColor = true;
            this.rdoProfesor.CheckedChanged += new System.EventHandler(this.rdoProfesor_CheckedChanged);
            // 
            // grbDatospersona
            // 
            this.grbDatospersona.Controls.Add(this.txtCalificacion);
            this.grbDatospersona.Controls.Add(this.txtSueldo);
            this.grbDatospersona.Controls.Add(this.txtNombre);
            this.grbDatospersona.Controls.Add(this.lblCalificacion);
            this.grbDatospersona.Controls.Add(this.lblSueldo);
            this.grbDatospersona.Controls.Add(this.lblNombre);
            this.grbDatospersona.Location = new System.Drawing.Point(123, 288);
            this.grbDatospersona.Name = "grbDatospersona";
            this.grbDatospersona.Size = new System.Drawing.Size(582, 126);
            this.grbDatospersona.TabIndex = 1;
            this.grbDatospersona.TabStop = false;
            this.grbDatospersona.Text = "Datos de la persona";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Location = new System.Drawing.Point(117, 92);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(389, 20);
            this.txtCalificacion.TabIndex = 5;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Location = new System.Drawing.Point(117, 67);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(389, 20);
            this.txtSueldo.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(117, 31);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(389, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Location = new System.Drawing.Point(10, 95);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(61, 13);
            this.lblCalificacion.TabIndex = 2;
            this.lblCalificacion.Text = "Calificacion";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Location = new System.Drawing.Point(7, 67);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(40, 13);
            this.lblSueldo.TabIndex = 1;
            this.lblSueldo.Text = "Sueldo";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnCapturarDatos
            // 
            this.btnCapturarDatos.Location = new System.Drawing.Point(631, 66);
            this.btnCapturarDatos.Name = "btnCapturarDatos";
            this.btnCapturarDatos.Size = new System.Drawing.Size(79, 49);
            this.btnCapturarDatos.TabIndex = 2;
            this.btnCapturarDatos.Text = "&Capturar Datos";
            this.btnCapturarDatos.UseVisualStyleBackColor = true;
            this.btnCapturarDatos.Click += new System.EventHandler(this.btnCapturarDatos_Click);
            // 
            // btnMostrarDatos
            // 
            this.btnMostrarDatos.Location = new System.Drawing.Point(631, 157);
            this.btnMostrarDatos.Name = "btnMostrarDatos";
            this.btnMostrarDatos.Size = new System.Drawing.Size(96, 81);
            this.btnMostrarDatos.TabIndex = 3;
            this.btnMostrarDatos.Text = "&Mostrar Datos";
            this.btnMostrarDatos.UseVisualStyleBackColor = true;
            this.btnMostrarDatos.Click += new System.EventHandler(this.btnMostrarDatos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarDatos);
            this.Controls.Add(this.btnCapturarDatos);
            this.Controls.Add(this.grbDatospersona);
            this.Controls.Add(this.grbTipoPersona);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEscuela_FormClosing);
            this.grbTipoPersona.ResumeLayout(false);
            this.grbTipoPersona.PerformLayout();
            this.grbDatospersona.ResumeLayout(false);
            this.grbDatospersona.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTipoPersona;
        private System.Windows.Forms.GroupBox grbDatospersona;
        private System.Windows.Forms.RadioButton rdoEstudiante;
        private System.Windows.Forms.RadioButton rdoProfesor;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCapturarDatos;
        private System.Windows.Forms.Button btnMostrarDatos;
    }
}

