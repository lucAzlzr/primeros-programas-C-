﻿using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.
            int n1, n2, resultado;

            Console.WriteLine("Ingrese un número:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro:");
            n2 = int.Parse(Console.ReadLine());

            resultado = n1 + n2;

            Console.WriteLine("El resultado es:" + resultado);
        }
    }
}
