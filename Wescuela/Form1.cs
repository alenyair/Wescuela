using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wescuela
{
    public partial class Form1 : Form
    {

        Persona persona = new Persona();

        public Form1()
        {
            InitializeComponent();
        }

        public void InicializarFormulario()
        {

        }

        private void btnCapturarDatos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("  Datos capturados");
            rdoEstudiante.Checked = false;
            rdoProfesor.Checked = false;
            txtCalificacion.Clear();
            txtNombre.Clear();
            txtSueldo.Clear();
            txtCalificacion.Enabled = true;
            txtSueldo.Enabled = true;
        }

        private void rdoProfesor_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoProfesor.Checked)
                {
                    txtCalificacion.Enabled = false;
                    txtSueldo.Enabled = true;
                }

            }
            catch
            {
                throw;
            }



        }

        private void rdoEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdoEstudiante.Checked)
                {
                    txtSueldo.Enabled = false;
                    txtCalificacion.Enabled = true;
                   
                }
            }
            catch 
            {

                throw;
            }
        }

        private void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            persona.Nombre = txtNombre.Text;
            
            string asiste = persona.Asistir();

            if (rdoEstudiante.Checked)
            {
                try
                {
                    persona.Calificacion = int.Parse(txtCalificacion.Text);
                    string estudia = persona.Estudiar();
                    DialogResult Resultado = MessageBox.Show("Nombre :    \t " + persona.Nombre +  "\nCalificacion:  \t" +
                      persona.Calificacion +"\n" +asiste +"\n" + estudia  );
                }
                catch
                {

                    throw;
                }
            }

            else if (rdoProfesor.Checked)
            {
                persona.Sueldo = int.Parse(txtSueldo.Text);
                string enseña = persona.Enseñar();

                DialogResult Resultado = MessageBox.Show("Nombre:  \t"+ persona.Nombre + "\tSueldo: $"  + persona.Sueldo +
                    "\n" + asiste + "\n" + enseña);

            }
            else
            {
                MessageBox.Show("Error; verifique que haya seleccionado alguna de las siguientes opciones(Estudiante o Profesor)");
            }


        }

        private void frmEscuela_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resultado = MessageBox.Show(" Realmente desea salir?", " Comfirmacion ",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = (resultado == DialogResult.No);
        }
    }
}
