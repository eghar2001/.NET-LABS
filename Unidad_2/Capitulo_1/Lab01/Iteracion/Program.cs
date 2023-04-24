namespace Iteracion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cantIteraciones = 5;
            string?[] arrayStrings = new string[cantIteraciones];
            for(int i =0; i<cantIteraciones; i++) {
                Console.Write($"Ingrese texto de la posicion {i} del array: ");
                arrayStrings[i] = Console.ReadLine();
               }
            Console.WriteLine();
            for(int i = cantIteraciones-1;i>=0;i--)
            {
                Console.WriteLine($"En la posicion {i} ingresó: '{arrayStrings[i]}'");
            }
        }
    }
}