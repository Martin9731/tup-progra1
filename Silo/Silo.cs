using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granero
{
    internal class Silo
    {
        public double Radio { get; set; }

        public double Altura { get; set; }

        public double Volumen()
        {
            double VolumenTotal = 0;
            VolumenTotal = Math.PI * Radio * Radio * Altura;
            // Para hacer el Radio de otra forma más elegante:
            // Math.Pow (Radio, 2) - donde Radio es lo que deseamos potenciar, y 2 la potencia a la que elevamos el número)
            return VolumenTotal;

        }

    }
}
