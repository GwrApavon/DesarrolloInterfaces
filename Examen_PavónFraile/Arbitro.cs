using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Arbitro : Persona
    {
        private int totalTarjetas;

        public Arbitro(string nombre, int edad, int totalTarjetas) 
        : base(nombre, edad)
        {

        }

        public int TotalTarjetas
        {
            set
            {
                totalTarjetas = value;
            }
            get
            {
                return this.totalTarjetas;
            }
        }
    }
}
