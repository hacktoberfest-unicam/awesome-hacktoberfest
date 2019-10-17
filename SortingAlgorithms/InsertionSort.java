import java.awt.Color;

public class InsertionSort {
	
	public static void viewArray(int[] array, int n) {
		for(int i=0;i<array.length;i++) {
			if(i==n) System.out.print("[*"+array[i]+"*]");
			else System.out.print("["+array[i]+"]");
		}
	}
	
	public static void viewArray(int[] array) {
		for(int i=0;i<array.length;i++) {
			System.out.print("["+array[i]+"]");
		}
	}
	
	public static void sort(int[] array) {
		
		int n = array.length; 
		System.out.print("\nARRAY INIZIALE: ");
		viewArray(array);
        for (int i = 1; i < n; ++i) { 
        	System.out.print("\n\n"+(i)+"° iterazione: ");
        	
            int key = array[i]; 
            viewArray(array,i);
            int j = i - 1; 
            
            while (j >= 0 && array[j] > key) { 
            	array[j + 1] = array[j]; 
                j = j - 1; 
            } 
        } 
        
        System.out.print("\n\nARRAY FINALE: ");
		viewArray(array);
    }

}
