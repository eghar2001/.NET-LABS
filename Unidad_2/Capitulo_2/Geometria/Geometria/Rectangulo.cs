using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo:Poligono
    {
        private double largo;
        private double ancho;

        public Rectangulo(double largo, double ancho)
        {
            if (ancho < 0 && largo<0)
            {
                throw new ArgumentException("No ingreso un ancho ni largo valido");
            }
            if (largo < 0)
            {
                throw new ArgumentException("No ingreso un largo valido");
            }
            if (ancho < 0)
            {
                throw new ArgumentException("No ingreso un ancho valido");
            }
            this.largo = largo;
            this.ancho = ancho;
        }
        public double Ancho
        {
            get => ancho;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No ingreso un ancho valido");
                }
                ancho = value;
            }
        }

        public double Largo
        {
            get => largo;
            set
            {   
                if (value < 0)
                {
                    throw new ArgumentException("No ingreso un largo valido");
                }
                largo = value;
            }
        }

        public override double CalcularPerimetro()
        {
            return Math.Round(2 * ancho + 2 * ancho,2);
        }

        public override double CalcularSuperficie()
        {
            return Math.Round(ancho * largo);
        }
    }
}