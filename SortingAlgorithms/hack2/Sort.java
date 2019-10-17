import java.io.*;
/**
 * Implementazione dello Stupid Sort
 * @author
 *
 */
public class Sort implements ISort {
	int contatore=0;
	@Override
	public int[] sort(int[] input) {
		System.out.println("Verranno ordinati " + input.length + " elementi");
		while (!isSorted(input))
		{
			bubbleSort(input);

		}
		System.out.println("Soluzione trovata! in "+ contatore+ " volte");
		return input;
	}

	public  int  bubbleSort(int[] input) {
		
	    boolean sorted = false;
	    int temp;
	    while(!sorted) 
	    {
	        sorted = true;
	        for (int i = 0; i < input.length - 1; i++) {
	            if (input[i] > input[i+1]) {
	                contatore++;
	            	temp = input[i];
	                input[i] = input[i+1];
	                input[i+1] = temp;
	                sorted = false;
	            }
	        }
	    }
	    this.contatore= contatore;
	    return  contatore;
	}
	//Verifico se la lista è ordinata in modo crescente
	private boolean isSorted(int[] i) {
		for (int x = 0; x < i.length - 1; ++x) {
			if (i[x] > i[x + 1]) {
				return false;
			}
		}
		return true;
	}

}
