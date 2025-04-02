using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    Punto DistanciaEjeCoordenadas = new Punto();
    Console.WriteLine("Inserte el valor de la coordenada X: ");
    string CoordX = Console.ReadLine();
    int CoordenadaX = Convert.ToInt32(CoordX);
    DistanciaEjeCoordenadas.CoordenadaX = CoordenadaX;

    Console.WriteLine("Inserte el valor de la coordenada Y ");
    string CoordY = Console.ReadLine();
    int CoordenadaY = Convert.ToInt32(CoordY);
    DistanciaEjeCoordenadas.CoordenadaY = CoordenadaY;

    string CoordenadaPunto = DistanciaEjeCoordenadas.CoordenadaPunto();

    Console.WriteLine("Las coordenadas ingresadas del punto son: " + CoordenadaPunto);

    double DistanciaCoordenadas = DistanciaEjeCoordenadas.DistanciaCoordenadas();
    Console.WriteLine("La distancia del punto al eje de coordenadas es: " + DistanciaCoordenadas);

    Console.WriteLine("Presione cualquier tecla para salir del programa.");
    Console.ReadKey();
}
