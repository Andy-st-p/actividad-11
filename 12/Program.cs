namespace _12
{
    internal class Program
    {
        //Restar dos números utilizando una función Restar(int a, int b) que retorne el resultado.
        static void Restar(int a, int b)
        {
            int resultado = a - b;
            Console.WriteLine($"El resultado de restar {b} - {a} es: {resultado}");
        }
        static void Main(string[] args)
        {
            Restar(6,4);
        }
    }
}
