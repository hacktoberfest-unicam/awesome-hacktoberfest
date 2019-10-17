import java.util.Scanner;

public class Giocatore {
	private String[] scelta = { "Sasso", "Carta", "Forbici" };
	private Scanner input = new Scanner(System.in);

	public String mossa() {
		double i = 0;
		do
			i = 3 * Math.random();
		while (i > 3);
		System.out.println();
		System.out.println("Scelta della CPU: " + scelta[(int) i]);
		return scelta[(int) i];
	}

	public String chiediMossa() {
		System.out.println("Quale mossa vuoi fare? Scrivi: S - C - F");
		System.out.print("La tua scelta: ");
		switch (input.next()) {
		case "s":
			return "S";
		case "c":
			return "C";
		case "f":
			return "F";
		case "S":
			return "S";
		case "C":
			return "C";
		case "F":
			return "F";
		}
		return "0";
	}
}
