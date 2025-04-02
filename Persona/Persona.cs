using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    internal class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public char Sexo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        // Todas las cuestiones de Nombre Edad Sexo Peso y Altura, las genero como Public porque de otro modo después
        // para llamarlas va a estar complicado. Voy a ver qué pasa si les pongo internal o private.
        public int calcularIMC()
        {
            int calcularIMC = 0;
            double masacorporal = 0;
            masacorporal = Peso / Math.Pow(Altura, 2);
            if (masacorporal < 20) { calcularIMC = -1; }
            else if (masacorporal >= 20 && masacorporal <= 25) { calcularIMC = 0; }
            else { calcularIMC = 1; }
            return calcularIMC;
        }
        // Es interesante ver cómo 'Peso' está en blanco porque referencia al atributo de la clase en sí
        // (ver líneas 15 y 22 )
        // Lo mismo va a pasar con Edad, Altura, y todas las que estén referenciadas luego, si están bien referenciadas
        // van a a parecer en blanquito también. Es el modo en el que sabés que está todo bien

        public bool esMayorDeEdad()
        {
            bool esMayorDeEdad = false;
            if (Edad >= 18) { esMayorDeEdad = true; }
            else { esMayorDeEdad = false; }
            return esMayorDeEdad;
        }
    }
}
