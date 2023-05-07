using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clases
{
    public class Jugada
    {
        private int _intentos;
        private bool _adivino;
        private int _numero;

        public Jugada(int maxNumero)
        {
            Random rnd = new Random();
            _numero = rnd.Next(maxNumero);

            _adivino = false;
            _intentos = 0;
        }


        

        public int Intentos
        {
            get => _intentos;
        }

        public int Numero
        {
            get => _numero;
        }

        public bool Comparar(int numero_intentado)
        {
            if (Numero == numero_intentado)
            {
                _adivino = true;
                return true;
            }
            _intentos++;
            return false;
        }
    }
}