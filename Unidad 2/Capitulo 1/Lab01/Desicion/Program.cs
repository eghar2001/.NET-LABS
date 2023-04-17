namespace Desicion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            /*
            Console.Write("Ingrese un texto: ");
            string? inputTexto = Console.ReadLine();
            if (!String.IsNullOrEmpty(inputTexto))

            {
                Console.WriteLine();

                Console.WriteLine("Ingrese una opcion:");
                Console.WriteLine("1-Pasar texto a MAYUSCULA");
                Console.WriteLine("2-Pasar texto a minuscula");
                Console.WriteLine("3- Mostrar largo del texto");
               
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                if(opcion.Key == ConsoleKey.D1)
                {
                    Console.WriteLine($"El text en mayuscula es: {inputTexto.ToUpper()}");
                }
                else if(opcion.Key == ConsoleKey.D2)
                {
                    Console.WriteLine($"El texto en minuscula es: {inputTexto.ToLower()}");
                }
                else if( opcion.Key == ConsoleKey.D3)
                {
                    Console.WriteLine($"El largo de la cadena es: {inputTexto.Length}");
                }
                else
                {
                    Console.WriteLine("No ingresó una opción válida");
                }
                Console.ReadKey();
            */


            //Ejercicio 2
            Console.Write("Ingrese un texto: ");
            string? inputTexto = Console.ReadLine();
            Console.WriteLine();
            if (!String.IsNullOrEmpty(inputTexto))

            {
                

                Console.WriteLine("Ingrese una opcion:");
                Console.WriteLine("1-Pasar texto a MAYUSCULA");
                Console.WriteLine("2-Pasar texto a minuscula");
                Console.WriteLine("3- Mostrar largo del texto");

                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.WriteLine();
                Console.WriteLine();
                switch (opcion.Key)
                {
                    case ConsoleKey.D1:
                        Console.WriteLine($"El texto en mayuscula es: {inputTexto.ToUpper()}");
                        break;

                    case ConsoleKey.D2:
                        Console.WriteLine($"El texto en minuscula es: {inputTexto.ToLower()}");
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine($"El largo del texto es: {inputTexto.Length}");
                        break;
                    default:
                        Console.WriteLine("No ingresó una opcion correcta");
                        break;
                }
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Ponga un texto");
            }
            
        }
    }
}