package Dsa;

public class LargestElement {
	
    public static void main(String[] args) {
    	int arr[] = {3,1,2,4,7,5,8};
    	int max = arr[0];
    	 for(int i = 1; i < arr.length ;i++) {
    		 if(arr[i] > max) {
    			 max = arr[i];
    		 }
    	 }
    	 System.out.println("Largest Element : "+max);
    }
}