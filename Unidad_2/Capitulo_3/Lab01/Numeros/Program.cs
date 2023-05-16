namespace Numeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Parametros
            const int CANTIDAD_NUMEROS = 30;
            const int NUMERO_MAXIMO = 50;


            Random rnd = new Random();
            List<int> numeros = new List<int>();
            for (int i = 0;i<CANTIDAD_NUMEROS;i++)
            {
                numeros.Add(rnd.Next(NUMERO_MAXIMO));
            }
            var numeros_mayores_a_20 = numeros.Where(n => n > 20);
            Console.WriteLine("Numeros mayores a 20");
            foreach(int n in numeros_mayores_a_20)
            {
                Console.WriteLine(n);
            }

        }  
    }
 }
