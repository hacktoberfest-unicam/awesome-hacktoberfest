package Cifrario;
import java.util.Scanner;
public class Caesar {
		
	public static void main(String [] args) {
		Scanner sc =new Scanner(System.in);
		System.out.println("Wright here your secrets:");
		String secrets= sc.nextLine();
		System.out.println("Enter the character shift value:");
		int shift= sc.nextInt();
		String text="";
		char alphabet;
		
		for(int i=0;i<secrets.length();i++) {
			
			alphabet=secrets.charAt(i);
			
			if(alphabet>='a' && alphabet<='z') {
				alphabet= (char)(alphabet+shift);
		
				if(alphabet>'z') {
					alphabet=(char) (alphabet+'a'-'z'-1);
				}
				text=text+alphabet;
			}
				else if(alphabet>='A' && alphabet<='Z') {
					alphabet= (char)(alphabet+shift);
				
				if(alphabet>'Z') {
						alphabet=(char) (alphabet+'A'-'Z'-1);
				}
					text=text+alphabet;
				}
	
		}
		System.out.println("Message :" +text);
		System.exit(0);
	}
	
}
