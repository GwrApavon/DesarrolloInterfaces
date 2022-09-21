package Ejercicio_03;

import java.util.Scanner;

/**
 * 
 */

/**
 * @author angel
 *
 */
public class EsCapicua {

	/**
	 * @param args
	 */
	
	public static int reverseNum(int num) {
		int reverse = 0;
		
		while(num > 0) {
			reverse = reverse*10 + (num%10);
			num /= 10;
		}
		
		return reverse;
	}
	
	public static boolean esCapicua(int num, int reverse) {
		
		return num == reverse;

	}

	public static void main(String[] args) {

		Scanner s = new Scanner(System.in);
		
		int num;
		
		System.out.println("Introduce un número: ");
		num = s.nextInt();
		if(esCapicua(num, reverseNum(num))) {
			System.out.println("El número es Capicua");
		}
		else {
			System.out.println("El número no es capicua");
		}
		s.close();
	}

}

