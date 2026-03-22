namespace _19
{
    internal class Program
    {
        //Determinar si un número es múltiplo de otro utilizando una función EsMultiplo(int n, int m) que retorne verdadero o falso.
        static bool EsMultiplo(int n, int m)
        {
            return n % m == 0;
        }
        static void Main(string[] args)
        {
            bool resultado= EsMultiplo(1,2);
            Console.WriteLine(resultado);
        }
    }
}
