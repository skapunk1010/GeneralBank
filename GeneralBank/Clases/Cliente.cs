using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Cliente : Persona
    {
        public Cliente(String n, String ap, String am, String fechaNac,String[] cuentas):base(n,ap,am,fechaNac) 
        {
            this.cuentasAsociada = cuentas;
        }

        private String[] cuentasAsociada;
        public String[] CuentasAsociadas
        {
            get { return cuentasAsociada; }
            set { cuentasAsociada = value; }
        }
    }
}
