using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGraft
{
    internal class Persona
    {
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Sexo { get; set; }

        public double Altura { get; set; }

        public double Peso { get; set; }

        public double CalcularIMC()
        {
            double pesoideal = 0;
            pesoideal = Peso / Math.Pow(Altura, 2);
            return pesoideal;

            if (pesoideal < 20)
            {
                return -1;
            }
            else if (pesoideal >= 20 && pesoideal <= 25)
            {
                return 0;
            }
            else if (pesoideal > 25)
            {
                return 1;
            }
        }

        public bool esMayorDeEdad()
        {
            if (Edad >= 21)
            {
                Console.WriteLine("La persona es mayor a 21 años de edad.");
                return true;
            }
            else
            {
                Console.WriteLine("La persona tiene menos de 21 años de edad.");
                return false;
            }
        }

    }
}
