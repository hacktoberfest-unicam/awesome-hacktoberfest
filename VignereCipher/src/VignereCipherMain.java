
public class VignereCipherMain{
	public static void main(String[] args) {
		VignereCipher cc = new VignereCipher("VERME");
		String plainText = "LEOGUARDALETIPESUINSTAGRAM";
		
		System.out.println("Testo cifrato: "+cc.encrypt(plainText));
		System.out.println("Testo in chiaro: "+cc.decrypt(cc.encrypt(plainText)));
	}
}
