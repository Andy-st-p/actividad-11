using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _6
{
    internal class Program
    {
        //Saludar a una persona utilizando una función Saludar(string nombre) que imprima “Hola + nombre”.
        static void Saludar(string Nombre)
        {
            Console.WriteLine("Hola " + Nombre);
        }
        static void Main(string[] args)
        { 
            
            Saludar("Anderson Son");

        }
    }
}
