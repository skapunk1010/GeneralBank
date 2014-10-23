using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Empleado : Persona
    {
        private String puesto;
        public String Puesto
        {
            get{return puesto;}
            set{puesto = value;}
        }

        private String horario;
        public String Horario
        {
            get{return horario;}
            set{horario = value;}
        }

        private float sueldo;
        public float Sueldo
        {
            get{return sueldo;}
            set{sueldo = value;}
        }

        private String fechaIngreso;
        public String FechaIngreso
        {
            get{return fechaIngreso;}
            set{fechaIngreso = value;}
        }

        private bool status;
        public bool Status
        {
            get{return status;}
            set{status = value;}
        }
    }
}
