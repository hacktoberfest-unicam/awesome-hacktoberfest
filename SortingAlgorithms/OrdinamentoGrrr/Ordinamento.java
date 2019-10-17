public class Ordinamento implements Sort {

	public int[] sort(int[] input) {
		
		boolean scambiato;
		do {
			scambiato = false;
			for (int i =0; i<=  input.length  - 2;i++) {
				if (input[ i ] > input[ i + 1 ]) {
					int temp = input[i];
					input[i] = input[i+1];
					input[i+1]=temp;
					scambiato = true;
				}
			}
			if (!scambiato) {
				break;
			}
			scambiato = false;
			for (int i= input.length - 2;i>=0;i--) {
				if (input[ i ] > input[ i + 1 ]) {
					int temp = input[i];
					input[i] = input[i+1];
					input[i+1]=temp;
					scambiato = true;
				}
			}
		} while (scambiato);	
			return input;	
	}
}