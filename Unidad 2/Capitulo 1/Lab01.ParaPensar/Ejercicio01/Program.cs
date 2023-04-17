namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            /*
             Construir una aplicación que sume dos números y proporcione el resultado con el formato siguiente:
            El resultado de la suma de < número uno > y < número dos > es < resultado >.
            */
            double num1 = 0;
            double num2 = 0;
            try
            {
                Console.Write("Ingrese nro 1: ");
                num1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese nro 2: ");
                num2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine($"El resultado de la suma de {num1} y {num2} es {num1 + num2}");

            }
            catch (FormatException e)
            {
                Console.WriteLine("Ingresó un formato incorrecto");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            
        }
    }
}