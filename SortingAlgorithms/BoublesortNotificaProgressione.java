
public class Main {
	public static void main(String args[]) {
		Main main = new Main();
		int l = 100000;
		int[] array = new int[l];
		for (int i=0; i<array.length;i++) {
			array[i]=(int) Math.floor(Math.random()*l+1);
		}
		main.bubbleSort(array);
		System.out.println("fatto!");
	}
	
	public void bubbleSort(int[] x) 
    {
    int temp = 0;
    int j = x.length-1;
    int prev =0;
    while(j>0) 
      {
      for(int i=0; i<j; i++) 
        {
        if(x[i]>x[i+1])   //scambiare il '>' con '<' per ottenere un ordinamento decrescente
          {
          temp=x[i]; 
          x[i]=x[i+1];
          x[i+1]=temp;
          }
        }
      j--;
      int perc = (int)((Math.pow(x.length, 2)-Math.pow(j, 2))/Math.pow(x.length, 2)*100);
      if (perc != prev) {
      	System.out.println(perc+"%");
      	prev=perc;
      }
      }
    }

}
