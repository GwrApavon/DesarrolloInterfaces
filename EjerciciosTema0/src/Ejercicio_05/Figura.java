/**
 * 
 */
package Ejercicio_05;

/**
 * @author alu
 *
 */
public abstract class Figura implements PropiedadesObjetos{
	
	protected String color;
	protected String nombreForma;
	protected Punto punto;
	
	public String getNombreForma() {
		return nombreForma;
	}
	public void setNombreForma(String nombreForma) {
		this.nombreForma = nombreForma;
	}
	
	public abstract String toString();
	
	public static Figura mayorArea(Figura f []) {
		int mayor = 0, cont = 0;
		double area1 = 0, areaaux = 0;
		
		do {
			area1 = f[cont].calcularArea();
			
			if(cont>0) {
				if(area1 > areaaux) {
					mayor = cont;
				}
			}
			
			areaaux = area1;
			cont++;
		}while(cont < 4);
		return f [mayor];
	}
}

	