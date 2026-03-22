namespace _13
{
    internal class Program
    {
        //Multiplicar dos números utilizando una función Multiplicar(int a, int b) que retorne el resultado.
        static void Multiplicar(int a, int b)
        {
            Console.WriteLine($"El resultado de multiplicar {a} x {b} es: {(a*b)}");
        }
        static void Main(string[] args)
        {
            Multiplicar(5,6);
        }
    }
}
