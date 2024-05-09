using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. 
            //Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.
            float totalFacturado, comision, sueldoFinal;

            Console.WriteLine("Total facturado:");
            totalFacturado = float.Parse(Console.ReadLine());

            comision = totalFacturado * 0.05F;
            sueldoFinal = comision + 15000;

            Console.WriteLine("El sueldo total a cobrar es " + sueldoFinal + " pesos ");
        }
    }
}
