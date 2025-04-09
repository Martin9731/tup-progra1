using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonaGraft

 // Recordar que al crear el proyecto inmediatamente hay que crear una clase (en este caso, Persona) a la cual le vamos a asignar atributos, métodos, y propiedades.
// Luego, llamarla desde acá, o sea el "main"
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona Gabriel = new Persona();
            Console.WriteLine("Ingrese el nombre de la persona: ");
            Gabriel.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la edad de la persona en números: ");
            Gabriel.Edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese H para hombre, o M para mujer. Use solo mayúsculas.");
            Gabriel.Sexo = Console.ReadLine();

            Console.WriteLine("Ingrese la altura de la persona. Use una coma o un punto para separar metros de centímetros, por ejemplo: 1,80.: ");
            Gabriel.Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el peso de la persona en kilogramos: ");
            Gabriel.Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("El IMC de la persona es " + Gabriel.CalcularIMC());

            Gabriel.esMayorDeEdad();

            Console.WriteLine("Presione cualquier tecla para salir.");

            Console.ReadKey();

        }
    }
}
