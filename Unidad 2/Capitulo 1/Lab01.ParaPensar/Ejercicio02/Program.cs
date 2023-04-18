namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2
            /*
             Crear una aplicación que te pida un año y verifique si el año es bisiesto o no. 

            Observación: Un año es bisiesto si es divisible por 4, excepto el último de cada siglo (aquel divisible por 100), 
            salvo que éste último sea divisible por 400.
             Es decir los años que sean divisibles por 4 serán bisiestos;
            aunque no serán bisiestos si son divisibles entre 100 (como los años 1700, 1800, 1900 y 2100) a no ser
            que sean divisibles por 400 (como los años 1600, 2000 ó 2400))



            */
            int anio = 0;
            try
            {   
                bool esBisiesto(int anio) {
                    return (anio % 4 == 0 && !(anio % 100 == 0)) || anio % 400 == 0;
                }
                Console.Write("Ingrese anio: ");
                anio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                if (esBisiesto(anio))
                {
                    Console.WriteLine($"El anio {anio} es bisiesto");
                }
                else
                {
                    Console.WriteLine($"El anio {anio} no es bisiesto");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.WriteLine("Ingresó un formato incorrecto");
            }
            catch (OverflowException)
            {
                Console.WriteLine();
                Console.WriteLine("Ingresó un numero por fuera del rango disponible");
                Console.WriteLine("El valor se debe encontrar en el rango [-2.147.483.648;2.147.483.647]");
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.ToString());
            }

            
        }

        }
    }
