namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 9
            /*
             Crear una aplicación que pida un número de filas y respecto a estas, dibuje un triángulo como el siguiente:
         *
        ***
       *****
      *******
     *********

             
             */
            try
            {
                Console.Write("Ingrese el numero de filas: ");
                int nroFilas = int.Parse(Console.ReadLine());

                int cantidadImparColumnas = 1 + 2 * (nroFilas);



                const int medio = 9 / 2 + 1;

                int amplitud = 0;
                while (amplitud < (int)cantidadImparColumnas / 2)
                {
                    for (int i = 1; i <= cantidadImparColumnas; i++)
                    {
                        if (i >= medio - amplitud && i <= medio + amplitud)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    amplitud++;
                    Console.WriteLine();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("No ingreso un formato válido para las filas");
            }
            catch(Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.ToString());
            }


        }
    }
}