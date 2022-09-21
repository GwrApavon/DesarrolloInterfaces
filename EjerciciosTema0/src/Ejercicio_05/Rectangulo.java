/**
 * 
 */
package Ejercicio_05;

/**
 * @author alu
 *
 */
public class Rectangulo extends Figura{
	
		protected double lado1, lado2;

		public Rectangulo(double lado1, double lado2) {
			this.lado1 = lado1;
			this.lado2 = lado2;
		}
		
		@Override
		public double calcularArea() {
			// TODO Auto-generated method stub
			return 0;
		}

		@Override
		public double calcularPerimetro() {
			// TODO Auto-generated method stub
			return 0;
		}

		@Override
		public String toString() {
			// TODO Auto-generated method stub
			return null;
		}

		public double getLado1() {
			return lado1;
		}

		public void setLado1(double lado1) {
			this.lado1 = lado1;
		}

		public double getLado2() {
			return lado2;
		}

		public void setLado2(double lado2) {
			this.lado2 = lado2;
		}
		
		
}
