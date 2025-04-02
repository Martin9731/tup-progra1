using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitación_unidad_2
{
    internal class Program
    { // 1 Pedir Datos de la comida (ordenás una milanesa)
      // 2 Crear el objeto y darle sus datos (cocinás la milanesa, le ponés los datos de dónde tiene que ir, cómo es, y tal)
      // 3 Hacer las salidas (que el objeto haga lo que tiene que hacer) (Sacás el pedido, y lo enviás a su domicilio, llega y la milanesa se come)
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese cuánto combustible tiene el auto: ");

            string Combustible = Console.ReadLine();

            double CombustibleActual = Convert.ToDouble(Combustible);

            Console.WriteLine("Ingrese cuántos kilómetros tiene el recorrido que desea hacer: ");

            string Kilómetrosarecorrer = Console.ReadLine();

            double Recorrido = Convert.ToDouble(Kilómetrosarecorrer);

            Auto FordFiesta = new Auto();

            FordFiesta.pCombustible = CombustibleActual;

            if (FordFiesta.Conducir(Recorrido) == true)
            {
                Console.WriteLine("Puede hacer el recorrido. Quedan " + FordFiesta.pCombustible + " litros de combustible");
            }
            else
            {
                Console.WriteLine("No hay combustible suficiente para el recorrido indicado.");
            }

            Console.WriteLine("El auto llegó a la estación con un total de " + FordFiesta.pCombustible + " litros.");

            Console.WriteLine("Ingrese la cantidad de litros a cargar: ");

            String LitrosCargados = Console.ReadLine();

            double doubLitrosCargados = Convert.ToDouble(LitrosCargados);

            double SobrantedeCombustible = FordFiesta.CargaCombustible(doubLitrosCargados);

            Console.WriteLine("Se derramó una cantidad total de " + SobrantedeCombustible + " litros.");

            Console.ReadKey();









        }
    }
}
