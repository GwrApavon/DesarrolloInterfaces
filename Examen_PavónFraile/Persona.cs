using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_PavónFraile
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;

        public string Nombre
        { 
            get
            {
                return this.nombre;
            }
        }
        public int Edad
        {
            get
            {
                return this.edad;
            }
        }
        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;    
        }

        public virtual string StringDatos()
        {
            return "Nombre: " + nombre + "Edad: " + edad;
        }
    }
}
