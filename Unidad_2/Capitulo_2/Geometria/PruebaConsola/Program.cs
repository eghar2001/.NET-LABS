using Geometria;

namespace PruebaConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangulo tri = new Triangulo(3, 4, 5);
            Console.WriteLine(tri.CalcularPerimetro());


            Cuadrado cua = new Cuadrado(4.7);
            Console.WriteLine( cua.CalcularSuperficie());
            
        }
    }
}