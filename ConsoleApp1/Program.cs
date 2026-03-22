namespace ConsoleApp1
{
    internal class Program
    {
        //Sumar dos números utilizando una función SumarMostrar(int a, int b) y mostrar el resultado.
        static void SumarMostrar(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"La suma de {a} y {b} es: {resultado}");
        }
        static void Main(string[] args)
        {
            SumarMostrar(5,2);
        }
    }
}
