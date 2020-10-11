using System;

namespace APPSUMAR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola Bienvenido");


            Console.WriteLine("Escribe tu nombre: ");
            string nombre = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Escribe tu primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Escribe tu segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            double resultado;


            resultado = num1 + num2;


            Console.WriteLine("Tu resultado " + nombre + " es " + resultado);


            Console.ReadLine();
        }
    }
}
