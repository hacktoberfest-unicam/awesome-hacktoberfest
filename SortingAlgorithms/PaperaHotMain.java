package sortChallenge;
/*
 *@author Marco Palmieri
 *@author Emanuele Gurini
 */
public class PaperaHotMain {
	
	public static void main(String[] args) {
		PaperaHotSort ph = new PaperaHotSort();
		
		int[] input = new int[] {6,30,45,7,0,1,31,34,12,3};
		int[] output = ph.sort(input);
		ph.print(output);	
	}

}
