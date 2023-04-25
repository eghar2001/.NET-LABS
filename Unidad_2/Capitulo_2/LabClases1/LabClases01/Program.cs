using Clases;

namespace LabClases01
{
    internal class Program
    
    {
        static void Main(string[] args)
        {
            A instanciaA = new A();
            B instanciaB = new B();

            Console.WriteLine("Metodos de A:\n");
            //Metodos de A
            instanciaA.MostrarNombre();
            instanciaA.M1();
            instanciaA.M2();
            instanciaA.M3();

            Console.WriteLine("\n\nMetodos de B:\n");
            //Metodos de B
            instanciaB.MostrarNombre();
            instanciaB.M1();
            instanciaB.M2();
            instanciaB.M3();
            instanciaB.M4();
        }
    }
}