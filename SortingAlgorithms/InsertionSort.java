
public class InsertionSort implements Sort{ 

	public int[] sort(int[] input) {
		
		 for (int i = 1; i < input.length; i++) {
		        int n = input[i];
		        int j = i - 1;
		        while(j >= 0 && n < input[j]) {
		        	if (n < input[j]) {
		        		System.out.println("Ho scambiato " + n +" con " + input[j]);
		        	}
		            input[j+1] = input[j];
		            
		            j--;
		        }
		        System.out.println("");
		        input[j+1] = n;
		    }	
		
		return input;
	}

}