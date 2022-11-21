using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosObjetos_01
{
    public class EmpleadoEspecial : Empleado, IPastaGansa
    {
        protected double percenBen;
        protected double pastaGanada;

        public EmpleadoEspecial(string nombre, string apellidos, int edad, string dni, double salario, string? nTelef)
        : base(nombre, apellidos, edad, dni, salario, nTelef)
        {
            percenBen = 5;
            pastaGanada = 0;
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
        public double ganarPasta(double dineroEmpresa)
        {
            if (dineroEmpresa > 0)
            {
                PastaGanada = dineroEmpresa * (PercenBen / 100);
                return dineroEmpresa * (PercenBen / 100);
            }
            return 0;
        }
        public string ToString(double dinEmpresa)
        {
            return base.ToString() + "\nPorcentaje de beneficio: " + PercenBen + "\nPasta Ganada: " + ganarPasta(dinEmpresa);
        }
        public override double hacienda()
        {
            return PastaGanada * (30.5 / 100);
        }
    }
}
