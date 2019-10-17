
public class Decifrario {
	
	public static String decifratura(String str) {
		String strD=new String();
		for(int i=0;i<str.length();i++) {
			strD=strD+(char)(str.charAt(i)-3);
		}
		return strD;
	}
}
