using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Rectangulo : Figura
    {
        protected double lado1, lado2;

        public Rectangulo(double lado1, double lado2)
        {
            this.color = "blanco";
            this.punto = new Punto(0, 0);
            this.setNombreForma("Rectangulo");
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        
        public override double CalcularArea()
        {
            double area = lado1 * lado2;
            return area;
        }

        
        public override double CalcularPerimetro()
        {
            double perimetro = lado1 * 2 + lado2 * 2;
            return perimetro;
        }

        
        public override String ToString()
        {
            return this.nombreForma + this.color + " de  centro (" + punto.getCoordenadaX() + "," + punto.getCoordenadaY() 
            + ") área " + CalcularArea()
            + " y perímetro " + CalcularPerimetro();
        }

        public double getLado1()
        {
            return lado1;
        }

        public void setLado1(double lado1)
        {
            this.lado1 = lado1;
        }

        public double getLado2()
        {
            return lado2;
        }

        public void setLado2(double lado2)
        {
            this.lado2 = lado2;
        }

    }
}
