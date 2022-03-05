using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
   public  class Prestamo
    {
        public string NombreApellidoCliente { get; set; }
        public int CuitCliente { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public decimal MontoTotalCredito { get; set; }
        public decimal TasaInteres { get; set; }
        public int CantidadCuotas { get; set; }
        public decimal MontoCuota { get; set; }

        public Prestamo(string NombreApellidodelCliente, int CuitCliente,DateTime FechadelPrestamo,decimal MontoTotalCredito,decimal TasaInteres, int CantidadCuotas)
        {
            this.NombreApellidoCliente = NombreApellidodelCliente;
            this.CuitCliente = CuitCliente;
            this.FechaPrestamo = FechadelPrestamo;
            this.MontoTotalCredito = MontoTotalCredito;
            this.TasaInteres = TasaInteres;
            this.CantidadCuotas = CantidadCuotas;
            decimal MontodelaCuota = MontoTotalCredito * TasaInteres / CantidadCuotas;

        }
}
}

