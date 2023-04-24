namespace Ejercicio07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 7
            /*
             Calcular los N primeros números primos gemelos.
             */
            bool esPrimo(int num)
            {
                bool primo = num>=1;
                for(int i = 2; i < num; i++)
                {
                    primo = primo && (num % i != 0);
                }
                return primo;
            }
            
            
            Console.WriteLine("ENTER: mostrar el proximo nro primo gemelo ");
            Console.WriteLine("Otra tecla: Salir del programa");
            ConsoleKeyInfo opcion = Console.ReadKey();
            int primoAnterior = 1;
            int numeroActual = 2;
            
            while (opcion.Key == ConsoleKey.Enter) {
                while (!esPrimo(numeroActual))
                {
                    numeroActual++;
                }
                if(numeroActual==primoAnterior + 2)
                {
                    Console.WriteLine($"{primoAnterior} y {numeroActual} son primos gemelos");
                }
                primoAnterior = numeroActual;
                numeroActual++;
                

                opcion = Console.ReadKey();
            }


            
        }
    }
}