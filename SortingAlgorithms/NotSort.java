public class NotSort implements Sort{
	@Override
	public int[] sort(int[] input) throws InterruptedException{
		Thread.sleep(10000);
		System.out.println("NON HO VOGLIA DI ORDINARE INTERI!!!");
		System.out.println("Ordinerò lettere!");
		System.out.println("A B C D E F G H I J K L M N O P Q R S T U V W X Y Z");
		return input;
	}
	
	NotSort(int[] input) throws InterruptedException{
		realsort(sort(input));
	}
	
	private void realsort(int[] input) throws InterruptedException{
		Thread.sleep(1000);
		for(int i=0;i<input.length;i++){
			for(int j=i;j<input.length;j++){
				if(input[i]>input[j]){
					int tmp=input[i];
					input[i]=input[j];
					input[j]=tmp;
				}
			}
		}
		System.out.println("Per sta volta li ordino, vah!");
		for(int x:input){
			System.err.print(x+" ");
		}
		System.err.println();
	}
	public static void main(String... args){
      int[] x={1,5,3,88,33,65,100,35};
      try{
		new NotSort(x);
      }catch(InterruptedException ex){
        System.err.println("Il gioco è finito male!");
      }
	}
}