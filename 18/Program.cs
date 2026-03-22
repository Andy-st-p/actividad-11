namespace _18
{
    internal class Program
    {
        //Determinar el menor de tres números utilizando una función MenorDeTres(int a, int b, int c) que retorne el valor menor.
        static void MenorDeTres(int a, int b, int c)
        {
            int menor = a;
            if (b < menor)
            {
                menor = b;
            }
            if (c < menor)
            {
                menor = c;
            }
            Console.WriteLine($"El número menor entre {a}, {b} y {c} es: {menor}");
        }
        static void Main(string[] args)
        {
            MenorDeTres(6,2,3);
        }
    }
}
