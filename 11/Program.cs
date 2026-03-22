namespace _11
{
    internal class Program
    {
        //Sumar dos números utilizando una función Sumar(int a, int b) que retorne el resultado.
        
        static void Sumar( int a, int b)
        {
            Console.WriteLine($"La suma de {a}+{b} es: {(a+b)}");
        }
        static void Main(string[] args)
        {
            Sumar( 6, 4 );
        }
    }
}
