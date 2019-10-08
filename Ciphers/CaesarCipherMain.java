
public class CaesarCipherMain {
	public static void main(String[] args) {
		CaesarCipher cc = new CaesarCipher(12);
		String plainText = "Hello my name is Corrado";
		System.out.println("Testo cifrato: "+cc.encrypt(plainText));
		System.out.println("Testo in chiaro: "+cc.decrypt(cc.encrypt(plainText)));
	}
}
