﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Deposito : Movimiento
    {
        public Deposito(int id, Enum tipo, String d, String f, Empleado e, float m) : base(id, tipo, d, f, e)
        {
            this.monto = m;
        }

        private float monto;
        public float Monto
        {
            get { return monto; }
            set { monto = value; }
        }
    }
}