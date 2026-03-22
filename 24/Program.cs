namespace _24
{
    internal class Program
    {
        //Calcular el factorial de un número utilizando una función Factorial(int n).
        static void Factorial(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado *= i;
            }
            Console.WriteLine($"El factorial de {n} es: {resultado}");
        }
        static void Main(string[] args)
        {
            Factorial(5);
        }
    }
}
