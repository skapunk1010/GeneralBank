using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Empleado : Persona
    {
        public Empleado(String n,String ap, String am,String fechaNac, String p, float s,String  ingreso,bool status):base(n,ap,am,fechaNac) 
        {
            this.puesto = p;
            this.fechaIngreso = ingreso;
            this.sueldo = s;
            this.status = status;
        }

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
