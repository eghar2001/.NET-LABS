using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class JugadaConAyuda

    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public JugadaConAyuda(int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);

            _adivino = false;
            _intentos = 1;

        }

        public int Intentos
        {
            get => _intentos;


        }

        public bool Adivino
        {
            get => _adivino;


        }

        public int Numero
        {
            get => _numero;
            set
            {
                _numero = value;
            }
        }

        public bool Comparar(int num_intentado)
        {
            int distancia = num_intentado - Numero;
            if (distancia >10)
            {
                Console.WriteLine("Es mayor, esta muy lejos");
            }
            else if (distancia > 0 && distancia<=10)
            {
                Console.WriteLine("Es mayor, esta cerca");
            }
            else if (distancia < 0 && distancia>=-10)
            {
                Console.WriteLine("Es menor, esta cerca");
            }
            else if (distancia < -10)
            {
                Console.WriteLine("Es menor, esta lejos");
            }
            else 
            {
                _adivino = true;
                return true;
            }
            _intentos++;
            return false;

        }
    }
}
