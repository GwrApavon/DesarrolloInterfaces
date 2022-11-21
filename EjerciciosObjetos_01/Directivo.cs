using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObjetos_01
{
    public class Directivo : Empleado, IPastaGansa
    {
        protected string depEncargado;
        protected double percenBen;
        protected int numPersonas;
        private double pastaGanada;

        public int NumPersonas
        {
            set
            {
                if (value > 0)
                {
                    
                    switch (value)
                    {
                        case int when value < 10 && value > 0:    
                            this.percenBen = 2;
                            break;
                        case int when value > 10 && value < 51:
                            this.percenBen = 3.5;
                            break;
                        case int when value > 50:
                            this.percenBen = 4;
                            break;
                        default: Console.WriteLine("No tienes personas a cargo");
                            break;

                    }
                }
                else
                {
                    value = 0;
                }

                numPersonas = value;
            }
            get
            {
                return numPersonas;
            }
        }

        public string DepEncargado
        {
            set
            {
                depEncargado = value;
            }
            get
            {
                return depEncargado;
            }
        }

        public double PercenBen
        {
            get
            {
                return percenBen;
            }
        }
        public double PastaGanada
        {
            set 
            {
                pastaGanada += value; 
            }
            get
            {
                return pastaGanada;
            }
        }

        public Directivo(string nombreDep,int nPersonas, string nombre, string apellidos, int edad, string dni, double salario, string? nTelef)
        : base(nombre, apellidos, edad, dni, salario,nTelef)
        {
            DepEncargado = nombreDep;
            NumPersonas = nPersonas;
        }

        public static Directivo operator --(Directivo d)
        {
            if (d.percenBen > 0 && d.percenBen - 1 >= 0)
            {
                d.percenBen--;
            }
            return d;
        }

        public override void pedirDatos(){
            base.pedirDatos();
            Console.WriteLine("Introduce el nombre del departamento encargado: ");
            DepEncargado = Console.ReadLine();

            Console.WriteLine("Introduce la cantidad de personas a tu cargo: ");
            NumPersonas = Convert.ToInt32(Console.ReadLine());
        }

        public override string ToString()
        {
            return base.ToString() + "\nNombre de departamento encargado: " + DepEncargado + "\nPorcentaje de beneficio: " + PercenBen + "%\nNúmero de personas encargadas: " + NumPersonas
                   + "\nPasta Ganada: ";
        }

        public string ToString(double dinEmpresa)
        {
            return base.ToString() + "\nNombre de departamento encargado: " + DepEncargado + "\nPorcentaje de beneficio: " + PercenBen + "%\nNúmero de personas encargadas: " + NumPersonas
                   + "\nPasta Ganada: " + ganarPasta(dinEmpresa);
        }
        public double ganarPasta(double beneficiosEmpresa)
        {
            Directivo d = this;
            if (beneficiosEmpresa > 0)
            {
                PastaGanada = beneficiosEmpresa * (PercenBen / 100);
                return beneficiosEmpresa * (PercenBen / 100);
            }
            d--;
            return 0;
        }
        public override double hacienda()
        {
            return PastaGanada * (30 / 100);
        }
    }

    
}
