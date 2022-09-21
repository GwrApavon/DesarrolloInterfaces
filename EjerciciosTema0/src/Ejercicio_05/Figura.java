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
}
