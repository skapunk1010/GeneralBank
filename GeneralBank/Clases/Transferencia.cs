using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Transferencia : Movimiento
    {
        public Transferencia(float monto, String destino)
        {
            this.monto = monto;
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
