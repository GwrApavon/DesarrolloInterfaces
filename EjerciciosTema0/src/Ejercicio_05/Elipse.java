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
			super();
			this.rMayor = rMayor;
			this.rMenor = rMenor;
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
		
		
}
