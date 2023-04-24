using System.Globalization;

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

            
            Console.Write("Ingrese el mes en texto: ");
            string? mesString = Console.ReadLine();
            Console.WriteLine();
            try
            {
                int mesInt = DateTime.ParseExact(mesString, "MMMM", CultureInfo.CurrentCulture).Month;
                Console.WriteLine($"El mes {mesString.ToLower()} tiene el numero: {mesInt}");
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("No ingresó un més valido, intente otra vez");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);21
            }
        }
    }
}