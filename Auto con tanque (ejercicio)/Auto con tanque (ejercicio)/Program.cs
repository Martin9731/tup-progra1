using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_con_tanque__ejercicio_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Tanque miTanque = new Tanque();
            Auto miAuto = new Auto(miTanque);


            //        //Parte para cargar litros al vehículo
            //        Console.WriteLine("Ingrese los litros a cargar: ");

            //        string entradaLitros = Console.ReadLine();

            //        try
            //        {   // castear a int para que sea compatible el tipo de dato
            //            int litros = Convert.ToInt32(entradaLitros);

            //            int derramado = miAuto.CargarCombustible(litros);

            //            if (derramado > 0)
            //                Console.WriteLine($"Se derramaron {derramado} litros.");

            //            else
            //                Console.WriteLine("Combustible cargado correctamente.");
            //        }

            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Valor inválido para litros. Debe ingresar un número entero.");
            //        }
            //        // Acá hago el chequeo de cuánta nafta le queda al auto
            //        Console.WriteLine("Nivel actual: " + miAuto.ChequearNivel());

            //        // Ingreso de kilómetros a recorrer
            //        Console.WriteLine("Ingrese kilómetros a recorrer: ");

            //        string entradaKms = Console.ReadLine();
            //        try
            //        {   //castear a Double para que sea compatible el tipo de dato
            //            double kms = Convert.ToDouble(entradaKms);
            //            Console.WriteLine(miAuto.Conducir(kms));
            //        }
            //        catch (FormatException)
            //        {
            //            Console.WriteLine("Valor inválido para kilómetros. Debe ingresar un número.");
            //        }

            //        //Vuelvo a chequear el nivel de nafta del auto al final del programa para que me diga cuánto me quedó luego del recorrido.
            //        Console.WriteLine("Nivel final: " + miAuto.ChequearNivel());
            //        //mensaje de salida
            //        Console.WriteLine("Presione cualquier tecla para salir.");
            //        //el pequeño muchacho
            //        Console.ReadKey();
            //    }
            //}

            // Para redondear: Math.Round
            // O Math.Truncate para ignorar y CORTAR un v alor después de la coma.


            // Método más "elegante" con un Switch: 
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\n--- Menú ---");
                Console.WriteLine("1) Cargar combustible");
                Console.WriteLine("2) Chequear nivel de combustible");
                Console.WriteLine("3) Conducir");
                Console.WriteLine("4) Salir");
                Console.Write("Elige una opción (1-4): ");

                string opcion = Console.ReadLine();
                Console.WriteLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("Litros a cargar: ");
                        if (int.TryParse(Console.ReadLine(), out int litros))
                        {
                            int derramado = miAuto.CargarCombustible(litros);
                            Console.WriteLine(derramado > 0
                                ? $"Se derramaron {derramado} litros."
                                : "Combustible cargado correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Debes ingresar un número entero.");
                        }
                        break;

                    case "2":
                        Console.WriteLine(miAuto.ChequearNivel());
                        break;

                    case "3":
                        Console.WriteLine("Kilómetros a recorrer: ");
                        if (double.TryParse(Console.ReadLine(), out double kms))
                        {
                            Console.WriteLine(miAuto.Conducir(kms));
                        }
                        else
                        {
                            Console.WriteLine("Entrada inválida. Debes ingresar un número.");
                        }
                        break;

                    case "4":
                        salir = true;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
        }
    }
}

