public class Cifrario {
	
	public static String cifratura(String str) {
		String strC=new String();
		for(int i=0;i<str.length();i++) {
			strC=strC+(char)(str.charAt(i)+3);
		}
		return strC;
	}

}
