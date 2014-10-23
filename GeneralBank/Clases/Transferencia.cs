using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Transferencia : Movimiento
    {
        public Transferencia(int id, Enum tipo, String d, String f, Empleado e,float m, String destino): base(id,tipo,d,f,e) {
            this.monto = m;
            this.numCuentaDestino = destino;
        }

        private float monto;
        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        private String numCuentaDestino;
        public String NumCuentaDestino
        {
            get { return numCuentaDestino; }
            set { numCuentaDestino = value; }
        }
    }
}
