using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Program

        //144656532

        // Constructor: forma segura de inicializar todas las propiedades de una clase.

        //dadasjlfkjasdk01312938039
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro();
            Console.WriteLine("Ingrese el ISBN del libro: ");
            libro1.ISBN = Convert.ToInt32(Console.ReadLine());
            // Validar que el valor del ISBN sea igual a 13 números.

            Console.WriteLine("Ingrese el nombre del autor: ");
            libro1.Autor = Console.ReadLine();

            Console.WriteLine("Ingrese el título del libro ");
            libro1.Título = Console.ReadLine();

            Console.WriteLine("Ingrese el número de páginas del libro");
            libro1.Páginas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(libro1.MostrarLibro());

            Console.WriteLine("Presione cualquier tecla para salir del programa. ¡Gracias! ");

            Console.ReadKey();

        }
    }
}
