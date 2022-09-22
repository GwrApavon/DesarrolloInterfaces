/**
 * 
 */
package Ejercicio_05;

/**
 * @author alu
 *
 */
public class Elipse extends Figura {
		
		public double getrMayor() {
		return rMayor;
	}

	public void setrMayor(double rMayor) {
		this.rMayor = rMayor;
	}

	public double getrMenor() {
		return rMenor;
	}

	public void setrMenor(double rMenor) {
		this.rMenor = rMenor;
	}

		protected double rMayor, rMenor;

		public Elipse(double rMayor, double rMenor) {
			super.color = "blanco";
			super.punto = new Punto(0,0);
			super.setNombreForma("Elipse");
			this.rMayor = rMayor;
			this.rMenor = rMenor;
		}

		@Override
		public double calcularArea() {
			double area = (rMayor * rMenor)*Math.PI;
			return area;
		}

		@Override
		public double calcularPerimetro() {
			double perimetro = ((2*Math.PI)*(Math.sqrt((Math.pow(rMayor, 2) + Math.pow(rMenor, 2))/2)));
			return perimetro;
		}

		@Override
		public String toString() {
			return super.nombreForma + " " + super.color + " de  centro (" + punto.getCoordenadaX() + "," + punto.getCoordenadaY() + ") área " + calcularArea() 
			+ " y perímetro " + calcularPerimetro();
		}
		
		
}
