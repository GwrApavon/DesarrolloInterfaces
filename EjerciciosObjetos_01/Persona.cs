using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObjetos_01
{
    using System;

    public abstract class Persona
    {
        private string nombre;
        private string apellidos;
        private int edad;
        private string dni;

        public int Edad
        {
            set
            {
                if (value < 0) edad = 0;
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public string Apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }

        public string Dni
        {
            set
            {
                if (value.Length == 8) dni = value;
            }
            get
            {
                return apellidos;
            }
        }

        public Persona(string nombre, string apellido, int edad, string dni)
        {
            Edad = edad;
            Nombre = nombre;
            Apellidos = apellido;
            Dni = dni;
        }

        public Persona()
        : this("","",0,"")
        {
            
        }

        public string toString()
        {
            return "Nombre: " + Nombre + "\nApellidos: " + Apellidos + "\nEdad: " + Edad + "\nDni: " + Dni;
        }

        public abstract double hacienda();
    }
}
