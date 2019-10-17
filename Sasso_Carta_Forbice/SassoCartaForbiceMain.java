
public class SassoCartaForbiceMain {
	public static void main(String[] args) {
		Giocatore g = new Giocatore();
		Giocatore CPU = new Giocatore();

		System.out.println("Regole: ");
		System.out.println("1. Le forbici tagliano la carta\r\n" + "2. La carta avvolge il sasso\r\n"
				+ "10. Sasso rompe le forbici\n");

		Partita p = new Partita();
		while (true)
			p.Start(g, CPU);

	}
}
