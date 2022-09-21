package Ejercicio_01;

import java.util.Scanner;
/**
 * @author Ángel Pavón Fraile
 *
 */
public class HolaNombre {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub

			//variables
			String name;
			
			//teclado
			Scanner t = new Scanner(System.in);
			
			System.out.print("Introduzca su nombre:");
			name = t.nextLine();
			
			System.out.println("El nombre introducido es: " + name);
			
			t.close();
	}

}
