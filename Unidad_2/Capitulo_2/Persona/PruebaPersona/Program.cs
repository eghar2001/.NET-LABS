using PersonaName;
using System.Globalization;
using static PersonaName.Persona;

namespace PruebaPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona pers1 = new Persona("Nahuel","Coronel",new DateTime(2001,12,09), -5);
            Console.WriteLine($"Nombre: {pers1.Nombre}");
            Console.WriteLine($"Apellido: {pers1.Apellido}");
            Console.WriteLine($"fechaNacimiento: {pers1.FechaNac}");
            Console.WriteLine($"dni: {pers1.Dni}");
            Console.WriteLine($"Nombre completo: {pers1.GetFullName()}");
            Console.WriteLine($"edad: {pers1.GetAge()}");

        }
    }
}