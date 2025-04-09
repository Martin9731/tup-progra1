using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstappen
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Auto Volkswagen = new Auto();

            Console.WriteLine("Por favor, indique la cantidad de nafta con la que arranca el vehículo: ");
            double litrosacargar = 0;
            litrosacargar = Convert.ToDouble(Console.ReadLine());

            double resultadocarga;
            resultadocarga = Volkswagen.CargarCombustible(litrosacargar);

            Console.WriteLine("Por favor, ingrese la cantidad de kilómetros a recorrer: ");
            double kmarecorrer = 0;
            kmarecorrer = Convert.ToDouble(Console.ReadLine());
            bool resultado;
            resultado = Volkswagen.Conducir(kmarecorrer);
            if (resultado)
            {
                Console.WriteLine("Puede hacer el recorrido.");
            }
            else
            {
                Console.WriteLine("No puede hacer el recorrido con esa cantidad de litros.");
            }

            Console.WriteLine("Por favor, indique la cantidad de nafta en litros que desea cargar: ");
            litrosacargar = 0;
            litrosacargar = Convert.ToDouble(Console.ReadLine());
                     
            resultadocarga = Volkswagen.CargarCombustible(litrosacargar);
            Console.WriteLine("Se ha derramado una cantidad total de " + resultadocarga + " litros.");

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey();

        }
    }
}
