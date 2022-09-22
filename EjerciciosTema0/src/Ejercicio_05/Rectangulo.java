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
			super.color = "blanco";
			super.punto = new Punto(0,0);
			super.setNombreForma("Rectangulo");
			this.lado1 = lado1;
			this.lado2 = lado2;
		}
		
		@Override
		public double calcularArea() {
			double area = lado1 * lado2;
			return area;
		}

		@Override
		public double calcularPerimetro() {
			double perimetro = lado1*2 + lado2*2;			
			return perimetro;
		}

		@Override
		public String toString() {
			return super.nombreForma + super.color + " de  centro (" + punto.getCoordenadaX() + "," + punto.getCoordenadaY() + ") área " + calcularArea() 
			+ " y perímetro " + calcularPerimetro();
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
