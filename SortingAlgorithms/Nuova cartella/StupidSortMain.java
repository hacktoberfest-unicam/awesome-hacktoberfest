
/**
 * Classe Main dello StupidSort
 * @author corrado
 *
 */
public class StupidSortMain {
	public static void main(String[] args) {
		StupidSort example = new StupidSort();
		
		int[] input = new int[] {6,30,45,7,0,1,31,34,12,3};
		int[] solution = example.sort(input);
		
		print(solution);
	}
	
	static void print(int[] i) {
		for(int x : i) {
			System.out.print(x + " ");
		}
		System.out.println();
	}
}
