using static System.Math;

namespace Geometria
{
    public class Circulo
    {
        private double m_radio;

        public Circulo(double radio)
        {
            if (radio < 0)
            {
                throw new ArgumentException("No ingreso un radio valido");
            }
            m_radio = radio;
        }
        public double Radio
        {
            get {
                return  Math.Round(m_radio,2);
            }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("No ingreso un radio valido");
                }
                m_radio = value;
            }
        }

        public double CalcularPerimetro()
        {
            double perimetro = Math.PI * (2 * m_radio);
            return  Math.Round( perimetro, 2);
        }

        public double CalcularSuperficie()
        {
            double superficie = Math.PI * Math.Pow(m_radio,2);
            return Math.Round(superficie, 2);
        }
    }
}