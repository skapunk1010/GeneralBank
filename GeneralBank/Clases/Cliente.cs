using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Cliente : Persona
    {
        public Cliente(String n, String ap, String am, String fechaNac, Cuenta[] cuentas):base(n,ap,am,fechaNac) 
        {
            this.cuentasAsociada = cuentas;
        }

        private Cuenta[] cuentasAsociada;
        public Cuenta[] CuentasAsociadas
        {
            get { return cuentasAsociada; }
            set { cuentasAsociada = value; }
        }
    }
}
