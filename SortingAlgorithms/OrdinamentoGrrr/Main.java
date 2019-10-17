
public class Main {

	public static void main(String[] args) {
		
		Ordinamento esempio = new Ordinamento();
		
		int[] input = new int[] {6,30,45,7,0,1,31,34,12,3};
		int[] solution = esempio.sort(input);
		
		print(solution);
	}
	
	static void print(int[] i) {
		for(int x : i) {
			System.out.print(x + " ");
		}
		System.out.println();
	
	}

}
