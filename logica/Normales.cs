using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    class Normales:Cliente
    {
        public decimal MontoCapacidadAhorro { get; set; }
        public override decimal ObtenerTasaInteres()
        {
            return (15 / 100);
        }
        public override decimal CalcularMontoMaximoPrestamo()
        {
            return (75 / 100 * (SueldoNeto - CalcularGastosFijos() - MontoCapacidadAhorro));
        }

    }
}
