package Dsa;

public class secondLargest {
	public static void main(String[] args) {
		int arr[] = {2,1,3,4,3,7,6,7,5};
		int max = arr[0]; 
		for(int i = 1; i < arr.length ; i++) {
			if(arr[i] > max) {
				max = arr[i];
			}
		}
		int smax = -1;
		for(int i = 0 ; i < arr.length ; i ++) {
			if(arr[i] > smax && arr[i] != max ) {
				smax = arr[i];
			}
		}
		System.out.println("Second Largest Element : "+ smax);
	}
	
}
