namespace _21
{
    internal class Program
    {
        //Contar la cantidad de vocales dentro de un texto utilizando una función ContarVocales(string texto).
        static void ContarVocales(string texto)
        {
            int contador = 0;
            string vocales = "aeiouAEIOU";
            foreach (char c in texto)
            {
                if (vocales.Contains(c))
                {
                    contador++;
                }
            }
            Console.WriteLine($"El texto '{texto}' tiene {contador} vocales.");
        }
        static void Main(string[] args)
        {
            ContarVocales("DOMingo");
        }
    }
}
