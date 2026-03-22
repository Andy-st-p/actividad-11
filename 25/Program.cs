namespace _25
{
    internal class Program
    {
        //Determinar si un número es primo utilizando una función EsPrimo(int n) que retorne verdadero o falso.
        static bool EsPrimo(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            bool resultado=EsPrimo(5);
            Console.WriteLine(resultado);
        }
    }
}
