
/**
 * Implementazione dello Stupid Sort
 * @author corrado
 *
 */
public class StupidSort implements Sort {

	@Override
	public int[] sort(int[] input) {
		int counter = 0;
		System.out.println("Verranno ordinati " + input.length + " elementi");
		while (!isSorted(input)) {
			System.out.println("Comparo due numeri");
			shuffle(input);
			counter++;
			System.out.println("Siamo al tentativo numero " + counter + " di comparazione.");
		}
		System.out.println("Soluzione trovata! (mescolato per " + counter + " volte)");
		return input;
	}

	//Scambio in modo randomico 2 elementi della lista
	private void shuffle(int[] i) {
		for (int x = 0; x < i.length; ++x) {
			int index1 = (int) (Math.random() * i.length), index2 = (int) (Math.random() * i.length);
			int a = i[index1];
			i[index1] = i[index2];
			i[index2] = a;
		}
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