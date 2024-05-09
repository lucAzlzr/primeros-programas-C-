using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. 
            //Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.
            float kilometros, velocidad, tiempo;

            Console.WriteLine("Ingrese los kilómetros:");
            kilometros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la velocidad:");
            velocidad = float.Parse(Console.ReadLine());

            tiempo = kilometros / velocidad;

            Console.WriteLine("El tiempo que tardo en llegar de un punto al otro es de " + tiempo + " horas ");
        }
    }
}