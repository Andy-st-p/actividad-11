using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _5
{
    internal class Program
    {
        //Mostrar un menú simple utilizando una función MostrarMenu() con tres opciones.
        static void MostrarMenu()
        {
            Console.WriteLine("---Menú---");
            Console.WriteLine("1. Opción 1");
            Console.WriteLine("2. Opción 2");
            Console.WriteLine("3. Opción 3");
        }
        static void Main(string[] args)
        {
            MostrarMenu();
        }
    }
}
