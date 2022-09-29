using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Elipse : Figura
    {
        public double getrMayor()
        {
            return rMayor;
        }

        public void setrMayor(double rMayor)
        {
            this.rMayor = rMayor;
        }

        public double getrMenor()
        {
            return rMenor;
        }

        public void setrMenor(double rMenor)
        {
            this.rMenor = rMenor;
        }

        protected double rMayor, rMenor;

        public Elipse(double rMayor, double rMenor)
        {
            this.color = "blanco";
            this.punto = new Punto(0, 0);
            this.setNombreForma("Elipse");
            this.rMayor = rMayor;
            this.rMenor = rMenor;
        }

        public override double CalcularArea()
        {
            double area = (rMayor * rMenor) * Math.PI;
            return area;
        }
                
        public override double CalcularPerimetro()
        {
            double perimetro = ((2 * Math.PI) * (Math.Sqrt((Math.Pow(rMayor, 2) + Math.Pow(rMenor, 2)) / 2)));
            return perimetro;
        }

        
        public override String ToString()
        {
            return this.nombreForma + " " + this.color + " de  centro (" + punto.getCoordenadaX() + "," + punto.getCoordenadaY() 
            + ") área " + CalcularArea()
            + " y perímetro " + CalcularPerimetro();
        }
    }
}
