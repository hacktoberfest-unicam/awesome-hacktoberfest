
public class SassoCartaForbiceLizardSpockMain {
	public static void main(String[] args) {
		Giocatore g = new Giocatore();
		Giocatore CPU = new Giocatore();
		System.out.println("Regole: ");
		System.out.println("1. Le forbici tagliano la carta\r\n" + "2. La carta avvolge il sasso\r\n"
				+ "3. Il sasso uccide Lizard\r\n" + "4. Lizard avvelena Spock\r\n" + "5. Spock rompe le forbici\r\n"
				+ "6. Le forbici decapitano Lizard\r\n" + "7. Lizard mangia la carta\r\n"
				+ "8. La carta invalida Spock\r\n" + "9. Spock vaporizza il sasso\r\n" + "10. Sasso rompe le forbici\n");
		
		Partita p = new Partita();
		while (true)
			p.Start(g, CPU);
	}
}
