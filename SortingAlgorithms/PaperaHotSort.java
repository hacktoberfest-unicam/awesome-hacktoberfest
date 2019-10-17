package sortChallenge;

import java.lang.Thread;

public class PaperaHotSort implements Sort {

	/*
	 * INSERTION SORT
	 * 
	 * @Override
	 */
	
	public int[] sort(int[] input) {
		int key; 
		for(int j = 1 ; j <= input.length-1; j++) {
			key = input[j];
			int i = j - 1;
			while(i >= 0 && input[i] > key) {
				input[i + 1] = input[i];
				i = i - 1;
				print(input);
				try {
					Thread.sleep(200);
				} catch(InterruptedException e) {
					e.printStackTrace();
				}
			}
			input[i + 1] = key;
		}
		alert();
		return input;
	}
	
	
	/*
	 * METODO DI STAMPA
	 */
	
	public void print(int[] i) {
		for(int x : i) {
			System.out.print(x + " ");
		}
		System.out.println();
	}
	
	/*
	 * METODO DI ALERT: OPERAZIONE TERMINATA
	 */

	public void alert() {
		System.out.println("-----------------------");
		System.out.println("");
		System.out.println("Operazione Terminata!");
		System.out.println("Il risultato è:");
		System.out.println("");
	}

}



