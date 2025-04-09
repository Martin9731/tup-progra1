using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{

    // pregunta: ¿importa si no nombro las properties igual que Botta? No realmente, es una convención/buena práctica (es mejor hacerlo).
    // importa si no inicio atributos y solo uso properties? No cambia nada peeeeeeeeero debería usarlos porque es una buena práctica. Los atributos deben ser privados - es fidelidad a la programación orientada a objetos.
    // importa si no le pongo get y set como hace Botta? el 99% de las veces va a dar igual que esté o no vacío.
    // Más adelante Oscar va a empezar a usarlo vacío.
    internal class Libro
    {
        private int isbn;
        private string título;
        private string autor;
        private int páginas;

        public int ISBN { get; set; }

        public string Título { get; set; }

        public string Autor { get; set; }

        public int Páginas { get; set; }

        public string MostrarLibro()
        {
            return "El libro que usted busca es " + Título + " del autor " + Autor + " dispone de " + Páginas.ToString() + " páginas y su ISBN es " + ISBN.ToString(); 
        }
    }
}
