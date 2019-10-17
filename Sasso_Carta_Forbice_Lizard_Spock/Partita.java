
public class Partita {

	public void Start(Giocatore giocatoreUmano, Giocatore CPU) {
		controlloTurno(giocatoreUmano.chiediMossa(), CPU.mossa());
	}

	private void controlloTurno(String g1, String g2) {
		// Se il giocatore ha scelto Sasso
		if (g1.equals("S"))
			switch (g2) {
			case "Sasso":
				pareggio();
				break;
			case "Carta":
				perdita();
				break;
			case "Forbici":
				vincita();
				break;
			case "Lizard":
				vincita();
				break;
			case "Spock":
				perdita();
				break;
			}
		// Se il giocatore ha scelto Carta
		if (g1.equals("C"))
			switch (g2) {
			case "Sasso":
				vincita();
				break;
			case "Carta":
				pareggio();
				break;
			case "Forbici":
				perdita();
				break;
			case "Lizard":
				perdita();
				break;
			case "Spock":
				vincita();
				break;
			}
		// Se il giocatore ha scelto Forbici
		if (g1.equals("F"))
			switch (g2) {
			case "Sasso":
				perdita();
				break;
			case "Carta":
				vincita();
				break;
			case "Forbici":
				pareggio();
				break;
			case "Lizard":
				vincita();
				break;
			case "Spock":
				perdita();
				break;
			}
		// Se il giocatore ha scelto Lizard
		if (g1.equals("L"))
			switch (g2) {
			case "Sasso":
				perdita();
				break;
			case "Carta":
				vincita();
				break;
			case "Forbici":
				perdita();
				break;
			case "Lizard":
				pareggio();
				break;
			case "Spock":
				vincita();
				break;
			}
		// Se il giocatore ha scelto Spock
		if (g1.equals("SP"))
			switch (g2) {
			case "Sasso":
				vincita();
				break;
			case "Carta":
				perdita();
				break;
			case "Forbici":
				vincita();
				break;
			case "Lizard":
				perdita();
				break;
			case "Spock":
				pareggio();
				break;
			}

		if (g1.equals("0")) {
			System.out.println("Errore: la tua scelta non è un valore accettabile");
			System.out.println();
		}
	}

	private void pareggio() {
		System.out.println("Pareggio");
		System.out.println();
	}

	private void perdita() {
		System.out.println("Ha vinto la CPU");
		System.out.println();
	}

	private void vincita() {
		System.out.println("Hai vinto");
		System.out.println();
	}
}
