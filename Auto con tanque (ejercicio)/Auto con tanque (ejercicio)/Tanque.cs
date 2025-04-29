using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auto_con_tanque__ejercicio_
{
    internal class Tanque
    {
        //la capacidad normal del tanque
        private const int CapacidadNormalTanque = 49;
        //la reserva del tanque
        private const int CapacidadReserva = 5;

        //la capacidad total del tanque de nafta

        private int CapacidadTotal = CapacidadNormalTanque + CapacidadReserva;

        //el combustible que tiene el tanque en este momento
        private int combustibletanque;


        public int Combustible
        {
            get { return combustibletanque; }

            // validar que el valor del tanque de combustible no se salga de los parametros:
            set
            {
                // si el valor es mejor a 0, fijamos que el combustible sea igual a 0.
                if (value < 0)
                    combustibletanque = 0;
                // si el valor es mayor a la capacidad total lo limitamos
                else if (value > CapacidadTotal)
                    combustibletanque = CapacidadTotal;
                // si esta dentro del rango valido (es decir dentro de los 54 litros de nafta) lo asignamos
                else combustibletanque = value;
            }

        }

        // para cargar el combustible
        public int CargarCombustible(int litros)
        {
            if (litros <= 0)
                return 0;

            int combustiblePrevioACarga = Combustible;

            Combustible += litros;

            int litrosCargados = Combustible - combustiblePrevioACarga;

            int combustiblederramado = litros - litrosCargados;

            return combustiblederramado;

        }


        // método para medir el consumo de nafta en litros
        public void GastarCombustible(double litros)
        {
            if (litros > 0)
            {
                int litrosEnteros = (int)Math.Ceiling(litros);
                Combustible -= litrosEnteros;
            }
        }


        // la alerta del tanque de nafta, revisa el nivel de nafta, devuelve el porcentaje de combustible restante.
        public string AlertaNafta()

        {
            if (Combustible <= CapacidadReserva)

            {
                return "Nivel de nafta en reserva, por favor cargue de inmediato.";
            }

            double porcentajeNafta = (Combustible / (double)CapacidadTotal) * 100;

            int porcentajeNaftaAproximado = (int)Math.Round(porcentajeNafta);

            if (porcentajeNaftaAproximado == 25)
                return "Nivel: 25%";
            else if (porcentajeNaftaAproximado == 50)
                return "Nivel: 50%";
            else if (porcentajeNaftaAproximado == 75)
                return "Nivel: 75%";
            else if (porcentajeNaftaAproximado == 100)
                return "Nivel: Lleno";
            else
                return $"Nivel: {porcentajeNaftaAproximado}% (intermedio)";
        }




    }
}