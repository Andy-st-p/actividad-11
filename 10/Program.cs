namespace _10
{
    internal class Program
    {
        //Imprimir un texto varias veces utilizando una función ImprimirRepetido(string texto, int veces).
        static void ImprimirRepetido(string texto, int veces)
        {
            for (int i = 0; i < veces; i++)
            {
                Console.WriteLine(texto);
            }
        }
        static void Main(string[] args)
        {
            ImprimirRepetido("hola",6);
        }
    }
}
