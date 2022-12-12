using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public class Jugador : Persona
    {
        private int dorsal;
        private int goles;

        public int Dorsal
        {
            get
            {
                return this.dorsal;
            }
        }
        public int Goles
        {
            set
            {
                this.goles += value;
            }
            get
            {
                return this.goles;
            }
        }

        public override string StringDatos()
        {
            return base.StringDatos() + "\nDorsal: " + Dorsal + "\nGoles: " + Goles;
        }
        public Jugador(string nombre, int edad, int dorsal) 
        : base(nombre, edad)
        {
            this.dorsal = dorsal;
            this.goles = 0;
        }

    }
}
