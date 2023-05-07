using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado:Rectangulo
    {
        private double lado;

        public Cuadrado(double lado):base(lado,lado)
        {
            if(lado < 0)
            {
                throw new ArgumentException("No ingresó un lado valido");
            }
            this.lado = lado;
        }
        public double Lado
        {
            get => lado;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No ingresó un lado valido");
                }
                lado = value;   
            }
        }

        public new double CalcularArea()
        {
            return Math.Round(lado*4,2);
        }

        public new double CalcularPerimetro()
        {
            return Math.Round(Math.Pow(lado, 2), 2);
        }
    }
}