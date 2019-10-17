package alternative;

import java.util.Scanner;

public class CipherMain {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("Immettere la stringa per la crittografia: ");
		String message = new String();
		message = sc.next();
		Scanner io = new Scanner(System.in);
		System.out.println("Immettere il numero per la crittografia: ");
		int numero;
		numero = io.nextInt();
		System.out.println(Ciphers.cifratore(message, numero));
		sc.close();
		io.close();
	}
}
