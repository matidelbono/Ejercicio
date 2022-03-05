using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Riesgosos:Cliente
    {
        public int CantidadPrestamosAdeudaCuotas { get; set; }
        public decimal ValorTotalDeuda { get; set; }
        public override decimal ObtenerTasaInteres()
        {
            if (ValorTotalDeuda>=50000)
            {
                return (15 / 100 + 5 / 100);
            }
            return 0;
    }
        public override decimal CalcularMontoMaximoPrestamo()
        {
            return (70 / 100 * SueldoNeto - CalcularGastosFijos());
        }
    }
}
