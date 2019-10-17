import java.lang.Math;
import javax.swing.JOptionPane;

public class Main {

	public static void main(String[] args) {
		String pc = "";
		System.out.println("Ok! giochiamo!");
		double macchina = (int) Math.random() * 4;

		int Castato = (int) macchina;
		switch (Castato) {
		case 0:
			pc = "sasso";
			break;
		case 1:
			pc = "carta";
			break;
		case 2:
			pc = "forbice";
			break;
		case 3:
			pc = "Caze";
		case 4:
			pc = "Gattafò";
			break;
		}

		String giocatore1 = JOptionPane.showInputDialog("Scrivi 'sasso','carta', 'forbici', 'Caze' o 'Gattafò'");
		String x = "sasso";
		String y = "carta";
		String z = "forbice";
		String a = "Caze";
		String b = "Gattafò";
		System.out.println("Il tuo avversario ha scelto: " + pc);

		if (!giocatore1.equals(x) && !giocatore1.equals(z) && !giocatore1.equals(y)
				&& !giocatore1.equals(a) && !giocatore1.equals(b)) {

			System.out.println("Non so capito che m'hai scritto");

		}
		if (giocatore1.equals(pc)) {

			System.out.println("la partita è pari");
		}

		if (giocatore1.equals(x) && (pc.equals("forbice") || pc.equals("Gattafò")) || giocatore1.equals(z) && (pc.equals("carta") || pc.equals("Gattafò"))
				|| giocatore1.equals(y) &&(pc.equals("sasso") || pc.equals("Caze")) || giocatore1.equals(a) && (pc.equals("sasso") || pc.equals("forbici"))
				|| giocatore1.equals(b) && (pc.equals("carta") || pc.equals("Caze"))) {
			System.out.println("Hai vinto tu!");
		}

		else {

			System.out.println("Ha vinto il tuo avversario!!");
		}

	}

}