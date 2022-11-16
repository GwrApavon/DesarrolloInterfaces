using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObjetos_01
{
    using System;
    using System.Reflection.PortableExecutable;
    using System.Runtime.Intrinsics.X86;

    public abstract class Persona
    {
        protected string nombre;
        protected string apellidos;
        protected int edad;
        protected string dni;

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
                char letra = ' ';
                char[] letrasDni = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
                letra = letrasDni[Convert.ToInt32(dni) % 23];
                return dni + letra;
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

        public virtual string ToString()
        {
            return "Nombre: " + Nombre + "\nApellidos: " + Apellidos + "\nEdad: " + Edad + "\nDni: " + Dni;
        }

        public virtual void pedirDatos()
        {
            Console.WriteLine("Introduce tu nombre: ");
            Nombre = Console.ReadLine();

            Console.WriteLine("Introduce tus apellidos: ");
            Apellidos = Console.ReadLine();

            Console.WriteLine("Introduce tu edad: ");
            Edad = Convert.ToInt32(Console.ReadLine());

            int numericValue;
            string aux;
            bool isNumber;
            do {
                Console.WriteLine("Introduce tu dni (solo números) : ");
                aux = Console.ReadLine();

            } while (isNumber = int.TryParse(aux, out numericValue));
            
            
            
        }
        public abstract double hacienda();
    }
}
