namespace _22
{
    internal class Program
    {
        //Repetir un texto varias veces utilizando una función Repetir(string texto, int veces) que retorne el texto repetido.
        static void Repetir(string texto, int veces)
        {
            string resultado = "";
            for (int i = 0; i < veces; i++)
            {
                resultado += texto;
            }
            Console.WriteLine($"el texto se repetira {veces} veces :{resultado}");
        }
        static void Main(string[] args)
        {
            Repetir("domingo",2);
        }
    }
}
