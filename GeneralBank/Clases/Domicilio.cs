using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Domicilio
    {
        public Domicilio(String c, int ne, String ni, String col, String ciudad, String e, String cod) {
            this.calle = c;
            this.numeroExterior = ne;
            this.numeroInterior = ni;
            this.colonia = col;
            this.ciudad = ciudad;
            this.estado = e;
            this.codPostal = cod;
        }

        private String calle;
        public String Calle
        {
            get { return calle; }
            set { calle = value; }
        }

        private int numeroExterior;
        public int NumeroExterior
        {
            get { return numeroExterior; }
            set { numeroExterior = value; }
        }

        private String numeroInterior;
        public String NumeroInterior
        {
            get { return numeroInterior; }
            set { numeroInterior = value; }
        }

        private String ciudad;
        public String Ciudad
        {
            get { return ciudad; }
            set { ciudad = value; }
        }

        private String colonia;
        public String Colonia
        {
            get { return colonia; }
            set { colonia = value; }
        }

        private String estado;
        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        private String codPostal;
        public String CodPostal
        {
            get { return codPostal; }
            set { codPostal = value; }
        }
    }
}
