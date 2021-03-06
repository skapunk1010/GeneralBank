﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Movimiento
    {
        public enum Tipos { DEPOSITO, TRANSFERENCIA }

        //public Movimiento(int id, Enum tipo, String d, String f, Empleado e, String c)
        public Movimiento() {
            /*
            this.idMovimiento = id;
            this.tipo = tipo;
            this.descripcion = d;
            this.fecha = f;
            this.empleado = e;
            this.numCuenta = c;
            */
        }

        private int idMovimiento;
        public int IdMovimiento
        {
            get { return idMovimiento; }
            set { idMovimiento = value; }
        }

        private Movimiento.Tipos tipo;
        public Movimiento.Tipos Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private String descripcion;
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        private String fecha;
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private Empleado empleado;
        public Empleado Empleado
        {
            get { return empleado; }
            set { empleado = value; }
        }

        private String numCuenta;
        public String NumCuenta
        {
            get { return numCuenta; }
            set { numCuenta = value; }
        }

    }
}
