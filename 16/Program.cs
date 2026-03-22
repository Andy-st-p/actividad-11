using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _16
{
    internal class Program
    {
        //Determinar si un número es positivo utilizando una función EsPositivo(int n) que retorne verdadero o falso.
        static bool EsPositivo(int n)
        {
            return n > 0;
        }
        static void Main(string[] args)
        {
            bool resultado= EsPositivo(-5);
            Console.WriteLine(resultado);
        }
    }
}
