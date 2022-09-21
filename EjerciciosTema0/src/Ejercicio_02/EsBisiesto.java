package Ejercicio_02;

import java.util.Scanner;

/**
 * 
 */

/**
 * @author Ángel Pavón
 *
 */
public class EsBisiesto {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		//teclado 
		Scanner t = new Scanner(System.in);
		// variables 
		int year = 0;
		boolean valid = false;
		
		
		System.out.print("Introduce un año para saber si es bisiesto: ");
		year = t.nextInt();
		 
		
		valid = esBisiesto(year, valid);
		
		if(valid == true) {
			System.out.print("El año " + year + " es bisiesto");
		}
		else {
			System.out.println("El año " + year + " no es bisiesto");
		}
		t.close();
	}

	/**
	 * @param year
	 * @param valid
	 * @return
	 */
	private static boolean esBisiesto(int year, boolean valid) {
		if(year%4 == 0) {
			valid = true;
		}
		if(year%100 == 0) {
			valid = false;
		}
		if(year%400 == 0) {
			valid = true;
		}
		return valid;
	}

}

