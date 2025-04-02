using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Persona Persona1 = new Persona();

            Console.WriteLine("Ingrese el nombre de la persona:");
            string NombrePersona = Console.ReadLine();
            Persona1.Nombre = NombrePersona;

            Console.WriteLine("Ingrese la edad de la persona: ");
            string EdadPersona = Console.ReadLine();
            int EdadPersonaint = Convert.ToInt32(EdadPersona);
            Persona1.Edad = EdadPersonaint;

            // Recordar la validacion solo si es H o M, si ingresa otra cosa tiene que devolver un mensaje de error o un 'vuelva a ingresar
            // el dato'
            Console.WriteLine("Ingrese el sexo de la persona (H para Hombre, o M para Mujer)");
            string SexoPersona = Console.ReadLine();
            char SexoPersonastr = Convert.ToChar(SexoPersona);
            Persona1.Sexo = SexoPersonastr;

            Console.WriteLine("Ingrese el peso de la persona");
            string PesoPersona = Console.ReadLine();
            double PesoPersonadoub = Convert.ToDouble(PesoPersona);
            Persona1.Peso = PesoPersonadoub;


            Console.WriteLine("Ingrese la altura de la persona");
            string AlturaPersona = Console.ReadLine();
            double AlturaPersonadoub = Convert.ToDouble(AlturaPersona);
            Persona1.Altura = AlturaPersonadoub;

            int IMCdePersona = Persona1.calcularIMC();
            Console.WriteLine("El IMC de la persona es: " + IMCdePersona);

            Console.WriteLine("¿Es mayor de edad?");
            bool Mayordeedad = Persona1.esMayorDeEdad();
            if (Persona1.esMayorDeEdad() == true)
            {
                Console.WriteLine("La persona es mayor de edad.");
            }
            else Console.WriteLine("La persona es menor de edad.");

            Console.WriteLine("Presione cualquier tecla para salir del programa.");
            Console.ReadKey();
        }
    }
}
