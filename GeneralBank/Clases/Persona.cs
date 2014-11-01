using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Persona
    {
        public Persona(String n,String ap, String am, String fechaNac) {
            this.nombre = n;
            this.apellidoPaterno = ap;
            this.apellidoMaterno = am;
            this.fechaNacimiento = fechaNac;
        }

        private String nombre;
        public String Nombre
        {
            get{ return nombre;}
            set{nombre = value;}
        }
        private String apellidoPaterno;
        public String ApellidoPaterno
        {
            get { return apellidoPaterno;}
            set { apellidoPaterno = value;}
        }

        private String apellidoMaterno;
        public String ApellidoMaterno
        {
            get { return apellidoMaterno; }
            set { apellidoMaterno = value; }
        }

        private String fechaNacimiento;
        public String FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        private String nss;
        public String Nss
        {
            get { return nss; }
            set { nss = value; }
        }

        private String rfc;
        public String Rfc
        {
            get { return rfc; }
            set { rfc = value; }
        }

        private String curp;
        public String Curp
        {
            get { return curp; }
            set { curp = value; }
        }

        private Telefono[] telefonos;
        public Telefono[] Telefono
        {
            get { return telefonos; }
            set { telefonos = value; }
        }
    }
}
