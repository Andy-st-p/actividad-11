namespace _8
{
    internal class Program
    {
        //Mostrar el cuadrado de un número utilizando una función MostrarCuadrado(int n)
        static void MostrarCuadrado(int n)
        {
            Console.WriteLine($"El cuadrado de {n} es: {(n*n)}");
        }
        static void Main(string[] args)
        {
            MostrarCuadrado(3);
        }
    }
}
