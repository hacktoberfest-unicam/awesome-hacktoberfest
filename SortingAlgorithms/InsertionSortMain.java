
public class InsertionSortMain {
	
	public static void main(String[] args) {
		
		InsertionSort ex = new InsertionSort();
		
		int[] input = new int[] {6,30,45,7,0,1,31,34,12,3};
		int[] solution = ex.sort(input);
		
		for (int i=0; i<solution.length; i++) {
			System.out.print(solution[i] + " ");
		} 
	}

}
