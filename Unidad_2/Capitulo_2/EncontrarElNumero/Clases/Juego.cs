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
            Console.Write("Presione C para comenzar el juego: ");
            while ( Continuar() )
            {
                Console.WriteLine();
                Console.WriteLine($"Ingrese un numero menor a {PreguntarMaximo()}");
                int numero_adivinado = PreguntarNumero();
                if (jugada.Comparar(numero_adivinado)){
                    Console.WriteLine("Felicidades !!! Adivinaste el numero!");
                    if (CompararRecord(jugada.Intentos))                    {
                        Console.WriteLine($"Felicidades!! Rompiste el record con {_record} intentos");
                    }
                    Console.WriteLine("Presione C para jugar otro");
                    jugada = new JugadaConAyuda(PreguntarMaximo());


                }
                else
                {
                    Console.WriteLine("No adivinaste el numero :(");
                    Console.Write("Presione C para continuar: ");                  
                    
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

        public bool Continuar()
        {
            ConsoleKeyInfo tecla = Console.ReadKey();
            return tecla.Key == ConsoleKey.C;
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
                Console.WriteLine("Se excedio del maximo o minimo numero posible por el tipo de dato");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e) {
                Console.WriteLine(e.ToString());
               }
            return numero;
        }
    }
}