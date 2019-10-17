package alternative;

public class Ciphers {
	public static final String ALFABETO = "abcdefghijklmnopqrstuvwxyz";

	public static String cifratore(String testo, int cambioCarattere) {

		testo = testo.toLowerCase();
		String testoCifrato = "";
		for (int i = 0; i < testo.length(); i++) {
			int posizioneChar = ALFABETO.indexOf(testo.charAt(i));
			int valoreChiave = (cambioCarattere + posizioneChar) % 26;
			char sostituiscoValore = ALFABETO.charAt(valoreChiave);
			testoCifrato += sostituiscoValore;
		}
		return testoCifrato;
	}
}