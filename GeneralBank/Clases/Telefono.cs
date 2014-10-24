using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Telefono
    {
        public Telefono(String lada, String tel, String tipo) {
            this.lada = lada;
            this.numero = tel;
            this.tipo = tipo;
        }

        private String lada;
        public String Lada
        {
            get { return lada; }
            set { lada = value; }
        }

        private String numero;
        public String Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private String tipo;
        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
    }
}
