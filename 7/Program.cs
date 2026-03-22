using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _7
{
    internal class Program
    {
        //Mostrar el doble de un número utilizando una función MostrarDoble(int n).
         static void MostrarDoble(int n)
        {
            Console.WriteLine($"El doble de {n} es {n * 2}");
        }
        static void Main(string[] args)
        {
          MostrarDoble(5);
        }
    }
}
