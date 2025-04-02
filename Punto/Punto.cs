using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto
{
    internal class Punto
    {
        public int CoordenadaX { get; set; }

        public int CoordenadaY { get; set; }

        public string CoordenadaPunto()
        {
            string CoordenadaPunto = "";
            CoordenadaPunto = CoordenadaX.ToString() + ";" + CoordenadaY.ToString();
            return "(" + CoordenadaPunto + ")";
        }
        public double DistanciaCoordenadas()
        {
            double DistanciaCoordenadas = 0;

            DistanciaCoordenadas = Math.Sqrt(Math.Pow(CoordenadaX, 2) + Math.Pow(CoordenadaY, 2));
            return DistanciaCoordenadas;

        }

    }
}

