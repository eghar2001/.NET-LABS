namespace Ejercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 4
            /*
             Construir una aplicación que proporcione todos los números pares entre el 1 y el 100.             
             */
            Console.WriteLine("Numeros pares del 0 al 100");
            for(int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}