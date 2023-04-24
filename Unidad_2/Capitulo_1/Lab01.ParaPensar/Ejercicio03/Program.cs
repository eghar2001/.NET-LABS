namespace Ejercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 3
            /*
             Hacer un programa para calcular la suma de la serie de Fibonacci.             
             */

            Console.WriteLine("Presione");
            Console.WriteLine("Enter: Para mostrar proximo nro de la serie de fibonacci");
            Console.WriteLine("Otra tecla: Para cerrar el programa");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Serie de Fibonacci: ");
            Console.WriteLine(1);
            
            UInt64 numPenult = 0;
            UInt64 numUlt = 1;
            UInt64 numAct;

            while(opcion.Key == ConsoleKey.Enter)
            {
                numAct = numPenult + numUlt;
                Console.WriteLine(numAct);
                numPenult = numUlt;
                numUlt = numAct;
                opcion = Console.ReadKey();
            }
        }
    }
}