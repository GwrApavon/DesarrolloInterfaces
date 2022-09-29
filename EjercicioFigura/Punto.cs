using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public class Punto
    {

        private int coordenadaX, coordenadaY;



        public Punto(int coordenadaX, int coordenadaY)
        {
            this.coordenadaX = coordenadaX;
            this.coordenadaY = coordenadaY;
        }

        public int getCoordenadaX()
        {
            return coordenadaX;
        }

        public void setCoordenadaX(int coordenadaX)
        {
            this.coordenadaX = coordenadaX;
        }

        public int getCoordenadaY()
        {
            return coordenadaY;
        }

        public void setCoordenadaY(int coordenadaY)
        {
            this.coordenadaY = coordenadaY;
        }
    }

}
