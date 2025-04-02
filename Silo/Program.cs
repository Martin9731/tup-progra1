using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Granero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Silo Almacenaje = new Silo();

            Console.WriteLine("Inserte el valor del Radio del Silo en metros: ");
            string Radiostr = Console.ReadLine();
            double Radio = Convert.ToDouble(Radiostr);
            Almacenaje.Radio = Radio;

            Console.WriteLine("Inserte el valor de la Altura del Silo en metros: ");
            string Alturastr = Console.ReadLine();
            double Altura = Convert.ToDouble(Alturastr);
            Almacenaje.Altura = Altura;

            double VolumenSilo = Almacenaje.Volumen();

            Console.WriteLine("El volumen máximo del silo es igual a: " + VolumenSilo + " metros cúbicos.");
            //NO OLVIDES AL MUCHACHO READKEY! 
            Console.ReadKey();
        }
    }
}
