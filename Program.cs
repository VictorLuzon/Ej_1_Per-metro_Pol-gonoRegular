using System;

namespace Ej_1
{
    /*Programa que calcula el perímetro de un polígono regular.
    Nota: Un polígono regular es aquel que tiene un número X de lados, todos de la misma medida.

        La fórmula para calcular el perímetro de cualquier polígono regular es la siguiente:
        medida de un lado * nº de lados, donde medida es X y lados es Y, la formula sería => x * y
        El siguiente programa pide al usuario el nº de lados de un supuesto polígono regular con los lados que quieras
        y le pide también la medida de uno de ellos. 
        Realiza la formula con los datos introducidos y muestra el resultado.*/
    class Program
    {
        static void Main(string[] args)
        {
            //Pide al usuario el nº de lados.
            Console.WriteLine("Escribe el nº de lados del supuesto polígono regular:");
            int lados = Int32.Parse(Console.ReadLine());

            //Pide al usuario la medida de uno de los lados.
            Console.WriteLine("Escribe la medida en cm de uno de los lados del supuesto polígono regular:");
            double medida = Double.Parse(Console.ReadLine());

            //El programa realiza la operación y muestra el resultado.
            double perimetro = medida * lados;
            Console.WriteLine("El perímetro de este supuesto polígono regular es: {0}cm.", perimetro);
        }
    }
}
