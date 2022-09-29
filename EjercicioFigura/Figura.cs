using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFigura
{
    public abstract class Figura : PropiedadesObjetos
    {
        protected String color;
        protected String nombreForma;
        protected Punto punto;

        public String getNombreForma()
        {
            return nombreForma;
        }
        public void setNombreForma(String nombreForma)
        {
            this.nombreForma = nombreForma;
        }

        public abstract String ToString();

        public static Figura MayorArea(Figura [] f )
        {
            int mayor = 0, cont = 0;
            double area1 = 0, areaaux = 0;

            do
            {
                area1 = f[cont].CalcularArea();

                if (cont > 0)
                {
                    if (area1 > areaaux)
                    {
                        mayor = cont;
                    }
                }

                areaaux = area1;
                cont++;
            } while (cont < 4);
            return f[mayor];
        }

        public abstract double CalcularArea();

        public abstract double CalcularPerimetro();
    }
}
