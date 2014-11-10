using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    public class Cuenta
    {
        public enum TipoProducto { CREDITO, DEBITO }
        public Cuenta (String numC, TipoProducto tipo, float saldoT, String fechaAp, bool status, Movimiento[] mov)
        {
            this.numeroCuenta = numC;
            this.tipoProducto = tipo;
            this.saldoTotal = saldoT;
            this.fechaApertura = fechaAp;
            this.status = status;
            this.movimientos = mov;
        }

        private String numeroCuenta;
        public String NumeroCuenta
        {
            get { return numeroCuenta; }
            set { numeroCuenta = value; }
        }

        private TipoProducto tipoProducto;
        public TipoProducto TipoProducto 
        {
            get { return tipoProducto; }
            set { tipoProducto = value; }
        }

        private float saldoTotal;

        public float SaldoTotal
        {
            get { return saldoTotal; }
            set { saldoTotal = value; }
        }

        private String fechaApertura;

        public String FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }

        private bool status;

        public bool Status
        {
            get { return status; }
            set { status = value; }
        }

        private Movimiento[] movimientos;

        public Movimiento[] Movimientos
        {
            get { return movimientos; }
            set { movimientos = value; }
        }
        
    }
}
