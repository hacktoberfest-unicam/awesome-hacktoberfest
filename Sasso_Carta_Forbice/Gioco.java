
import java.util.Scanner; 
import java.util.Random; 


public class Gioco {

	public static void main(String[] args) 
	{ 
	    String personPlay; 
	    String computerPlay = "";  
	    int computerInt; 
	    String Risposta; 


	    Scanner scan = new Scanner(System.in); 
	    Random generator = new Random(); 

	    System.out.println("Iniziamo a giocare!\n"
	    		+ "Fai la tua scelta: Carta = C, Sasso = S oppure Forbici = F");

	    System.out.println();

	     
	    computerInt = generator.nextInt(3)+1; 

	    

	    if (computerInt == 1) 
	       computerPlay = "S"; 
	    else if (computerInt == 2) 
	       computerPlay = "C"; 
	    else if (computerInt == 3) 
	       computerPlay = "F"; 

	    System.out.println("Fai la tua scelta: "); 
	    personPlay = scan.next();

	    
	    personPlay = personPlay.toUpperCase(); 

	    System.out.println("La scelta del computer è: " + computerPlay); 
 

 switch(personPlay) {
 case "S":
	 switch(computerPlay) {
	 case "S":
		 System.out.print("PAREGGIO!");
		 break;
	 case "C":
		 System.out.print("HAI PERSO!");
		 break;
	 case "F":
		 System.out.print("HAI VINTO!");
		 break;
	 
	 }
	 break;
 case "C":
	 switch(computerPlay) {
	 case "S":
		 System.out.print("HAI VINTO!");
		 break;
	 case "C":
		 System.out.print("PAREGGIO!");
		 break;
	 case "F":
		 System.out.print("HAI PERSO!");
		 break;
	 }
	 break;
 case "F":
	 switch(computerPlay) {
	 case "S":
		 System.out.print("HAI PERSO!");
		 break;
	 case "C":
		 System.out.print("HAI VINTO!");
		 break;
	 case "F":
		 System.out.print("PAREGGIO!");
		 break;
 }
	    

   }
  }
}