using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Juego
    {
        private int _record;

        public Juego()
        {
            
        }

        public void ComenzarJuego()
        {
            JugadaConAyuda jugada = new JugadaConAyuda(PreguntarMaximo());
            Console.WriteLine("Bienvenido al juego!!!\n");
            Console.WriteLine(jugada.Numero);
            Console.Write("Presione J para jugar: ");
            ConsoleKeyInfo tecla = Console.ReadKey();
            Console.WriteLine();
            while ( tecla.Key == ConsoleKey.J || tecla.Key == ConsoleKey.C)
            {
                Console.WriteLine($"Ingrese un numero menor a {PreguntarMaximo()}");
                int numero_adivinado = PreguntarNumero();
                if (jugada.Comparar(numero_adivinado)){
                    Console.WriteLine("Felicidades !!! Adivinaste el numero!");
                    if (CompararRecord(jugada.Intentos))                    {
                        Console.WriteLine($"Felicidades!! Rompiste el record con {_record} intentos");
                    }
                    
                    

                }
                else
                {
                    Console.WriteLine("No adivinaste el numero :(");
                    Console.Write("Presione: C para continuar -- J para jugar otro numero");
                    tecla = Console.ReadKey();
                    Console.WriteLine() ;
                    if(tecla.Key == ConsoleKey.J)
                    {
                        Continuar(jugada);
                        Console.WriteLine("Se reseteó el número");
                    }
                }


            }

        }

        private bool CompararRecord(int new_record)
        {
            
            if (new_record < _record || !Convert.ToBoolean(_record))
            {
                _record = new_record;
                return true;
            }
            return false;
        }

        public void Continuar(JugadaConAyuda jugada)
        {
            jugada = new JugadaConAyuda(PreguntarMaximo());
        }

        private int PreguntarMaximo()
        {
            return 50;
        }

        private int PreguntarNumero()
        {
            int numero = 0;
            try
            {
                numero = int.Parse(Console.ReadLine());
                
            }
            catch (FormatException e) {
                Console.WriteLine("Ingrese un formato de numero válido");
                Console.WriteLine(e.ToString());
            }
            catch(OverflowException e)
            {
                Console.WriteLine("Se excedio del maximo o minimo numero posible");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
               }
            return numero;
        }
    }
}