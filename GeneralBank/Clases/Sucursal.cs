using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneralBank.Clases
{
    class Sucursal
    {
        public Sucursal() { 
        }

        private Empleado[] empleados;
        public Empleado[] Empleados
        {
            get { return empleados; }
            set { empleados = value; }
        }

        private Cliente[] clientes;
        public Cliente[] Clientes
        {
            get { return clientes; }
            set { clientes = value; }
        }

        private Domicilio domicilio;
        public Domicilio Domicilio
        {
            get { return domicilio; }
            set { domicilio = value; }
        }

        private Telefono telefono;
        public Telefono Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
    }
}
