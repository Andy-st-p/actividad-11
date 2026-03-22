namespace ConsoleApp3
{
    internal class Program
    {
        //Calcular la suma de los números del 1 hasta N utilizando una función SumarDel1AlN(int n).
        static void SumarDel1AlN(int n)
        {
            int suma = 0;
            for (int i = 1; i <= n; i++)
            {
                suma += i;
            }
            Console.WriteLine($"La suma de los números del 1 al {n} es: {suma}");
        }
        static void Main(string[] args)
        {
            SumarDel1AlN(5);
        }
    }
}
