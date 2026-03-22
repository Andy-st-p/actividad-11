namespace ConsoleApp2
{
    internal class Program
    {
        //Dividir dos números utilizando una función Dividir(double a, double b) que retorne el resultado
        static void Dividir(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("No se puede dividir por cero.");
                return;
            }
            double resultado = a / b;
            Console.WriteLine($"El resultado de dividir {a} entre {b} es: {resultado}");
        }
        static void Main(string[] args)
        {
            Dividir(0,5);
        }
    }
}
