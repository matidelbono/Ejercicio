using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Vip:Cliente
    {
        public decimal MontoGastadoTarjetaCredito { get; set; }
        public decimal MontoFinanciacionActual { get; set; }
        public override decimal ObtenerTasaInteres()
        {
            if (MontoFinanciacionActual-CalcularGastosFijos()>100000)
            {
                return (15 / 100 + 4 / 100);
            }
            return 0;
    }
        public override decimal CalcularMontoMaximoPrestamo()
        {
            return (80 / 100 * (SueldoNeto - CalcularGastosFijos() + MontoFinanciacionActual - MontoGastadoTarjetaCredito));
        }
    }
}
