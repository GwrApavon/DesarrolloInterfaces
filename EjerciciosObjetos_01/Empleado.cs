using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EjerciciosObjetos_01
{
    public class Empleado : Persona
    {
        private double salario;
        private int irpf;
        private string? nTelef;

        public double Salario
        {
            set
            {
                switch (value)
                {
                    case 1 when value < 600:
                        this.irpf = 7;
                        break;
                    case 2 when value > 600 && value < 3000:
                        this.irpf = 15;
                        break;
                    case 3 when value > 3000:
                        this.irpf = 20;
                        break;
                }
                this.salario = value;
            }
            get
            {
                return this.salario;
            }
        }

        public int Irpf
        {
            get
            {
                return irpf;
            }
        }

        public string NTelef
        {
            set
            {
                bool esValido = true;
                for (int i = 0; i<value.Length; i++)
                {
                    if (value[i] < 0 && value[i]>9)
                    {
                        esValido = false;
                        break;
                    }
                }
                if (esValido)
                {
                    this.nTelef = value;
                }
                else
                {
                    this.nTelef = "";
                }
            }
            get
            {
                if (this.nTelef == null) return "+34" + this.nTelef;
                else return "Numero de telefono no establecido";
            }
        }

        public override string ToString()
        {
            return base.ToString() + "\nSalario: " + Salario + "\nIrpf: " + Irpf + "%\nNúmero de telefono: " + NTelef ;
        }

        public string ToString(int x)
        {
            switch (x)
            {
                case 0:
                    return "Nombre: " + base.Nombre + "\nSalario: " + Salario + "\nIrpf: " + Irpf + "%\nNúmero de telefono: " + NTelef;
                case 1:
                    return "Apellidos: " + base.Apellidos + "\nSalario: " + Salario + "\nIrpf: " + Irpf + "%\nNúmero de telefono: " + NTelef;
                case 2:
                    return "Edad: " + base.Edad + "\nSalario: " + Salario + "\nIrpf: " + Irpf + "%\nNúmero de telefono: " + NTelef;
                case 3:
                    return "DNI: " + base.Dni + "\nSalario: " + Salario + "\nIrpf: " + Irpf + "%\nNúmero de telefono: " + NTelef;
                default:
                    return "Introduzca un número válido (0-3)";
            }
            
        }
        public Empleado()
        : base()
        {
            
        }

        public Empleado(string nombre, string apellidos, int edad, string dni, double salario, int irpf, string? nTelef)
        : base(nombre,apellidos,edad,dni)
        {
            Salario = salario;;
            NTelef = nTelef;
        }

        public override double hacienda()
        {
            return Irpf*Salario/100;
        }

    }
}
