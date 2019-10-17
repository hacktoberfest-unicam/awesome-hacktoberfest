
public class SassoCartaForbiceMain {
	public static void main(String[] args) {
		Giocatore g = new Giocatore();
		Giocatore CPU = new Giocatore();

		Partita p = new Partita();
		while (true)
			p.Start(g, CPU);

	}
}
