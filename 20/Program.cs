using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _20
{
    internal class Program
    {
        //Contar la cantidad de caracteres de un texto utilizando una función ContarLetras(string texto).
        static void ContarLetras(string texto)
        {
            Console.WriteLine($"El texto '{texto}' tiene {texto.Length} caracteres.");
        }
        static void Main(string[] args)
        {
            ContarLetras("domingo");
        }
    }
}
