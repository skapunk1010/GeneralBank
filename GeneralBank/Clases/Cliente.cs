using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Cliente : Persona
    {
        private String[] cuentasAsociada;
        public String[] CuentasAsociadas
        {
            get { return cuentasAsociada; }
            set { cuentasAsociada = value}
        }
    }
}
