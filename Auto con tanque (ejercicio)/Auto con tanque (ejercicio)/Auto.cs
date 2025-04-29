using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_con_tanque__ejercicio_
{
    internal class Auto
    {

        private Tanque _tanque;

        public Auto(Tanque tanque)

        {
            _tanque = tanque;
        }

        // es lo que hace que el auto funcione, devuelve mensaje si se puede o no conducir.
        public string Conducir(double kilometros)
        {
            if (kilometros <= 0)
                return "Distancia invalida.";

            double litrosNecesarios = kilometros / 11.0;

            if (_tanque.Combustible >= litrosNecesarios)
            {
                _tanque.GastarCombustible(litrosNecesarios);
                return $"Recorrido completado. Se usaron {litrosNecesarios:F2} litros.";
            }
            else
            {
                return "No hay combustible suficiente para el recorrido indicado.";
            }
        }
        public int CargarCombustible(int litros)
        {
            return _tanque.CargarCombustible(litros);
        }

        //Chequea el nivel de combustible en % y devuelve la alerta de nafta
        public string ChequearNivel()
        {
            return _tanque.AlertaNafta(); 
        }
    }

}