using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitación_unidad_2
{

    internal class Auto
    {
        double Combustible;

        double Kilómetros;

        const double CapacidadMáxima = 54;

        public double pCombustible
        {
            get { return Combustible; }
            set
            {
                Combustible = Math.Round(value, 2);
                Kilómetros = value * 11;
            }
        }
        public double pKilómetros { get; set; }

        public bool Conducir(double Kilómetrosarecorrer)


        {
            if (Kilómetros >= Kilómetrosarecorrer)
            {
                double KilómetrosRestantes = Kilómetros - Kilómetrosarecorrer;
                pCombustible = KilómetrosRestantes / 11;
                return true;
            }
            else { return false; }

            //Chequear cuántos kilómetros puede recorrer el Auto (ya la conversión está hecha antes en pCombustible)
            //Ingresar Recorrido (en Kilómetros)
            //Comparación: Recorrido > cantidad de km. disponible?
            //Si: Descontar Combustible usado en el recorrido; devolver nueva cantidad de Combustible restante
            //No: Enviar mensaje: "No hay suficiente combustible. Necesita cargar X combustible para hacer el recorrido.
        }

        public double CargaCombustible(double CantidadACargar)
        {
            if (CantidadACargar + Combustible <= CapacidadMáxima)
            {
                pCombustible = CantidadACargar + Combustible;
                return 0;
            }
            else { return CantidadACargar + Combustible - CapacidadMáxima; }




            //Ingresar Cantidadacargar en Combustible
            //Establecer de antemano CapacidadMáxima de Combustible (54)
            //Ya voy a tener fixed Combustible como CombustibleDisponible o algo así, no sé si usar una nueva variable para indicarme cuánto combustible tengo
            // actualmente
            //Hago una SUMA de Cantidadacargar + Combustible(Combustible disponible)
            //Siempre voy a sumar. No es que no voy a cargar acá.
            //Si la SUMA excede 54 litros, devolver un mensaje "Se han vertido X litros de Combustible"
            //ELSE, indicar la nueva capacidad de combustible

        }
    }






}
