using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo:Poligono
    {
        private double lado1;
        private double lado2;
        private double lado3;

        public Triangulo(double lado1, double lado2, double lado3)
        {   
            if (lado1<0 || lado2<0 || lado3<0 )
            {
                throw new ArgumentException("No ingreso un lado valido");
            }
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }

        public double Lado1
        {
            get => lado1;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No ingreso un lado valido");
                }
                lado1 = value;
            }
        }

        public double Lado2
        {
            get => lado2;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No ingreso un lado valido");
                }
                lado2 = value;
            }
        }

        public double Lado3
        {
            get => lado3;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("No ingreso un lado valido");
                }
                lado3 = value;
            }
        }

        public override double CalcularPerimetro()
        {
            
            return  Math.Round(lado1 + lado2 + lado3,2);
        }        

        public override double CalcularSuperficie()
        {
            double semiperimetro = this.CalcularPerimetro()/2;
            return Math.Sqrt(semiperimetro * (semiperimetro - lado1) * (semiperimetro - lado2) * (semiperimetro - lado3));
        }
    }
}