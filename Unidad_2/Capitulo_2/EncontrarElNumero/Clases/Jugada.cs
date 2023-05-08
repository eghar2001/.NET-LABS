namespace Clases
{
    public class Jugada

    {
        private bool _adivino;
        private int _intentos;
        private int _numero;

        public Jugada( int maxNumero)
        {
            Random rnd = new Random();
            Numero = rnd.Next(maxNumero);

            _adivino = false;
            _intentos = 1 ;

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
            if (num_intentado == Numero)
            {
                _adivino = true;
                return true;
            }
            _intentos++;
            return false;

        }
    }

    
}