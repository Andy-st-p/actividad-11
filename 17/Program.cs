namespace _17
{
    internal class Program
    {
        //Determinar el mayor de dos números utilizando una función Mayor(int a, int b) que retorne el valor mayor.
        static void Mayor(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine($"El número mayor entre {a} y {b} es: {a}");
            }
            else if (b > a)
            {
                Console.WriteLine($"El número mayor entre {a} y {b} es: {b}");
            }
            else
            {
                Console.WriteLine($"Los números {a} y {b} son iguales.");
            }
        }
        static void Main(string[] args)
        {
            Mayor(5,5);
        }
    }
}
