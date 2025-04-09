using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verstappen
{
    internal class Auto
    {
        //kmarecorrer para el método CONDUCIR, para poder ingresar cuánto precisamente sería lo que se haría.
        //La regla de negocio establece que cada litro son 11 kilómetros.
        private double kmarecorrer;

        //el combustible de entrada con el que contamos para el método CONDUCIR para saber si llegamos o no llegamos a nuestro destino.
        private double combustibleentanque;

        //esta es la capacidad máxima de combustible que tiene el auto para cargar; 49 de tanque, 5 de reserva todo junto porque no se discrimina, ni se distingue.
        const double capacidadmaxima = 54;

        public double pCombustibleentanque
        {
            get { return combustibleentanque; }
            set
            {
                combustibleentanque = Math.Round(value, 2);
                kmarecorrer = value * 11;
            }
        }

        public bool Conducir(double recorridodeusuario)

        {
            //Console.WriteLine("Por favor, ingrese la cantidad de kilómetros que desea recorrer: ");


            if (kmarecorrer >= recorridodeusuario)
            {
                recorridodeusuario = kmarecorrer - recorridodeusuario;
                pCombustibleentanque = recorridodeusuario / 11;
              //  Console.WriteLine("Puede hacer el recorrido.");
                return true;
            }
            else
            {
                //Console.WriteLine("No puede hacer el recorrido con esa cantidad de litros.");
                return false;
            }

        }
        
        public double CargarCombustible(double litrosacargar)
        {
            //Console.WriteLine("Ingrese la cantidad de combustible a cargar en litros: ");
            

            double combustiblerestante = 0;
            double combustiblederramado = 0;
            combustiblerestante = capacidadmaxima - combustibleentanque;
            
            if (litrosacargar <= combustiblerestante)
            {
                pCombustibleentanque = pCombustibleentanque + litrosacargar;
                //Console.WriteLine("Se cargaron " + litrosacargar + " y ahora usted dispone de "  + combustibleentanque + " litros.");
                return 0;
                
            }
            else 
            {
                combustiblederramado = litrosacargar - combustiblerestante;
                //Console.WriteLine("Usted ha cargado todo el tanque, pero ha derramado" + combustiblederramado + " litros.");
                return combustiblederramado;

            }
        }
    }
}
