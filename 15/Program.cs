namespace _15
{
    internal class Program
    {
        //Determinar si un número es par utilizando una función EsPar(int n) que retorne verdadero o falso.
         static bool EsPar(int n)
        {
            return n % 2 == 0;
        }
        static void Main(string[] args)
        {
            bool resultado = EsPar(5);
            Console.WriteLine(resultado);
        }
    }
}
