namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthToInt(string month)
            {
                string mesClave = month.ToLower();
                Dictionary<string, int> parMesEntero = new Dictionary<string, int>() {
                    { "enero",1},
                    {"febrero",2},  
                    {"marzo",3},
                    {"abril",4 },
                    {"mayo",5 },
                    {"junio",6 },
                    {"julio",7 },
                    {"agosto",8 },
                    {"septiembre",9 },
                    {"octubre",10 },
                    {"noviembre",11 },
                    {"diciembre",12 }
                };
                if (parMesEntero.ContainsKey(mesClave))
                {
                    return parMesEntero[mesClave];
                }
                else
                {
                    return -1;
                }
            }
            Console.Write("Ingrese el mes en texto: ");
            string? mesString = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine($"El mes {mesString.ToLower()} tiene el numero: {monthToInt(mesString)}");
            Console.ReadKey();
        }
    }
}