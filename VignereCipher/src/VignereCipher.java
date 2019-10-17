import java.lang.*;
public class VignereCipher implements Cipher{
	private String key;
	private String finale;
	public VignereCipher(String key) {
		this.key=key;
	}
	@Override
	public String encrypt(String plainText) {
		String testo=plainText;
		//key+=key+key+key+key+key;
		finale=""; // per rimuovere null
		char caratApp;
		int cont=0,i=0;
		for(i=0;i<plainText.length();i++) {
			caratApp=(char)( (key.charAt(cont)+testo.charAt(i))%26+'a');
			//System.out.println(key.charAt(cont)+ "ooo "+ testo.charAt(i));
			cont++;
			if(cont==key.length()) cont=0;
			finale+=caratApp;
		}
		return finale;
	}

	@Override
	public String decrypt(String cipherText) {
		String testo=cipherText;
		int n=-1;
		finale=""; // per rimuovere null
		char caratApp;
		int cont=0,i=0;
		for(i=0;i<cipherText.length();i++) {
			//if((testo.charAt(i)-key.charAt(cont)) > 0) {
			caratApp=(char) ((testo.charAt(i)-'a'-key.charAt(cont)-'a')%26+'a');
			if(caratApp>90) caratApp-=26;
			
			//System.out.println(key.charAt(cont)+ "ooo "+ testo.charAt(i)+ "    "+(testo.charAt(i)-key.charAt(cont))%26 );
		//	System.out.println(caratApp);
			cont++;
			if(cont==key.length()) cont=0;
			finale+=caratApp;
		}
		return finale;
	}
}
