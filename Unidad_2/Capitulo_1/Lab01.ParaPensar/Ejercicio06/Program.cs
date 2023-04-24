namespace Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Ejercicio 6
            /*
             Dado un número entero, que se convierta a número romano.
            */
            const int min = 1;
            const int max = 3000;
            string intToRoman(int num)
            {
                if (num >= min && num <= max)
                {
                    string nroRom = "";
                    string nroString = Convert.ToString(num);
                    string[,] posiblesRomanos = new string[4, 10] {                     
                        //unidades
                        { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" },
                        //decenas
                        { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" },
                        //cienes
                        { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" },
                        // miles
                        { "", "M", "MM", "MMM", "", "","","","","" },
                    };
                    int nroDecimal = 0;
                    int romano = 0;
                    for(int i = 0; i <nroString.Length; i++)
                    {
                        romano = (int)Char.GetNumericValue(nroString[i]);
                        nroDecimal = nroString.Length - 1 - i;
                        nroRom += posiblesRomanos[nroDecimal, romano];
                    }
                    return nroRom;
                }
                return "";
            }
            

            try
            {
                Console.WriteLine("-----Conversor de enteros a romanos-----");
                Console.WriteLine();
                Console.WriteLine($"Ingrese un numero entre {min} y {max}");
                int num = int.Parse(Console.ReadLine());
                if (num >= min && num <= max)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Su numero en romano es: {intToRoman(num)}");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("El numero esta fuera de rango");
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