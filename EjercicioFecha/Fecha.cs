using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFecha
{

	public class Fecha
	{

		private int dia;
		private int mes;
		private int anio;

		//CONSTRUCTOR FECHA
		Fecha(int dia, int mes, int anio)
		{
			this.dia = dia;
			this.mes = mes;
			this.anio = anio;
		}

		//COMPRUEBA SI ES BISIESTO
		public static Boolean EsBisiesto(int anio)
		{
			return (anio % 4 == 0 && (anio % 100 != 0) || (anio % 400 == 0));
		}

		// TO STRING
		public String ToString()
		{
			return dia + "/" + mes + "/" + anio;
		}

		//CALCULA EL ULTIMO DÍA DEL MES
		public static int UltimoDia(int mes, int anio)
		{
			int Udia = 0;

			switch (mes)
			{
				case 1:
					Udia = 31;
					break;
                case 3:
					Udia = 31;
                    break;
                case 5:
					Udia = 31;
                    break;
                case 7:
					Udia = 31;
                    break;
                case 8:
					Udia = 31;
                    break;
                case 11:
					Udia = 31;
                    break;
                case 12:
					Udia = 31;
                    break;
                case 2:
					if (EsBisiesto(anio))
					{
						Udia = 29;
					}
					else
					{
						Udia = 28;
					}
					break;
				case 4: Udia = 30;
					break;
                case 6: Udia = 30;
                    break;
                case 9: Udia = 30;
                    break;
                case 10: Udia = 30;
                    break;
            }
			return Udia;
		}

		//CREA UN OBJETO FECHA
		public static Fecha CrearFecha()
		{
			int dia = 0, mes = 0, anio = 0;

			Console.Write("Introduce un año: ");

			anio = int.Parse(Console.ReadLine());

			do
			{

				Console.Write("Introduce un mes: ");
				mes = int.Parse(Console.ReadLine()); ;

			} while (mes <= 0 || mes > 12);

			do
			{

				Console.Write("Introduce un día: ");
				dia = int.Parse(Console.ReadLine());

			} while (dia > UltimoDia(mes, anio) || dia <= 0);


			return new Fecha(dia, mes, anio);
		}

		// GENERA UN OBJETO FECHA A PARTIR DE OTRO (DIA SIGUIENTE)
		public Fecha DiaSiguiente()
		{
			int dia2 = 0, mes2 = 0, anio2 = 0;
			if (dia == UltimoDia(mes, anio))
			{
				dia2 = 1;
				if (mes == 12)
				{
					mes2 = 1;
					anio2 = anio + 1;
				}
				else
				{
					mes2 = mes + 1;
					anio2 = anio;

				}
			}
			else
			{
				dia2 = dia + 1;
				mes2 = mes;
				anio2 = anio;

			}
			return new Fecha(dia2, mes2, anio2);
		}

		// COMPRUEBA SI UNA FECHA ES ANTERIOR A OTRA

		public Boolean EsAnterior(Fecha f)
		{

			if (this.anio != f.anio)
				return (this.anio < f.anio);

			else
				if (this.mes != f.mes)
				return (this.mes < f.mes);

			else
					if (this.dia != f.dia)
				return (this.dia < f.dia);

			return false;
		}
	}
}
