import java.util.Scanner;

/**
 * 
 */

/**
 * @author alu
 *
 */
public class Fecha {

		private int dia;
		private int mes;
		private int anio;
		private static Scanner s;
		
		//CONSTRUCTOR FECHA
		Fecha (int dia, int mes, int anio){
			this.dia = dia;
			this.mes = mes;
			this.anio = anio;
		}
		
		//COMPRUEBA SI ES BISIESTO
		public static boolean esBisiesto(int anio) {
			return (anio%4 == 0 && (anio%100 != 0) || (anio%400 == 0));
		}

		// TO STRING
		public String toString() {
			return dia + "/" + mes + "/" + anio;
		}
		
		//CALCULA EL ULTIMO DÍA DEL MES
		public static int ultimoDia(int mes, int anio) {
			int Udia=0;
			
			switch(mes) {
				case 1, 3, 5, 7, 8, 11 ,12 : Udia = 31;
				break;
				case 2: 
					 if(esBisiesto(anio)) {
						 Udia = 29;
					 }
					 else {
						 Udia = 28;
					 }
				break;
				case 4, 6, 9, 10: Udia = 30;
			}
			return Udia;
		}
		
		//CREA UN OBJETO FECHA
		public static Fecha crearFecha() {
			s = new Scanner(System.in);
			int dia=0,mes= 0, anio= 0;
			
			System.out.println("Introduce un año: ");
			
			anio = s.nextInt();
			s.nextLine();
			
			do {
			
				System.out.println("Introduce un mes: ");
				mes = s.nextInt();
				s.nextLine();
				
			}while(mes<=0 || mes >12);
			
			do {
				
				System.out.println("Introduce un día: ");
				dia = s.nextInt();
				s.nextLine();
				
			}while(dia > ultimoDia(mes, anio) || dia<=0);
			

			return new Fecha(dia, mes, anio);
		}
		
		// GENERA UN OBJETO FECHA A PARTIR DE OTRO (DIA SIGUIENTE)
		public Fecha diaSiguiente() {
			int dia2 = 0, mes2 = 0, anio2 = 0;
			if(dia == ultimoDia(mes,anio)) {
				dia2 = 1;
				if(mes==12) {
					mes2 = 1;
					anio2 = anio+1;
				}
				else {
					mes2 = mes+1;
					anio2 = anio;
				
				}
			}
			else {
				dia2 = dia+1;
				mes2 = mes;
				anio2 = anio;
				
			}
			return new Fecha(dia2,mes2,anio2);
		}
		
		// COMPRUEBA SI UNA FECHA ES ANTERIOR A OTRA
		
		public boolean esAnterior(Fecha f) {
			
			if(this.anio != f.anio) 
				return (this.anio < f.anio);
			
			else 
				if(this.mes != f.mes) 
					return (this.mes < f.mes);
				
				else 
					if (this.dia != f.dia)
						return (this.dia < f.dia);
				
			return false;
		}
}


