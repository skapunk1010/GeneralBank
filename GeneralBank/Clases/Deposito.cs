using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Deposito : Movimiento
    {
        //public Deposito(int id, Enum tipo, String d, String f, Empleado e, float m, String c): base(id, tipo, d, f, e, c)
        public Deposito(float monto)
        {
            this.monto = monto;
        }

        private float monto;
        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}
