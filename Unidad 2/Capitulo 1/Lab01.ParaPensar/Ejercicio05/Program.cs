namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 5
            /*
             Construir una aplicación que reciba el nombre de un mes del año como el parámetro y proporcione su número correspondiente.
            Debe ser con el formato: < Nombre del mes > + < número del mes >.
             */

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