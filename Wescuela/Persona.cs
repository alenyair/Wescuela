using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wescuela
{
    class Persona
    {

        #region[Definicion de variables]
        string nombre;
        private double sueldo;
        private int calificacion;

        public Persona()
        {
            Nombre = "";
            Sueldo = 0;
            Calificacion = 0;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double Sueldo
        {
            get { return sueldo; }
            set { sueldo = value; }
        }

        public int Calificacion
        {
            get { return calificacion; }
            set { calificacion = value; }
        }

        #endregion

        public string Asistir()
        {
            string Asiste = (Nombre + "  asiste a la escuela..");
            return Asiste;
        }


        public string Enseñar()
        {
            string enseña = (Nombre + "  Enseña a la escuela");
            return enseña;
        }

        public double Salario(double sueldo)
        {
            Sueldo = sueldo;
            return sueldo;
        }

        public int Notas(int calificacion)
        {
            calificacion = Calificacion;
            return Calificacion;
        }
        public string Estudiar()
        {
            string estudia = (Nombre + "  Esta estudiando..");
            return estudia;
        }
    }


}
