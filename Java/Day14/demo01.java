import java.util.Scanner;

class pattern
{
    int sum = 0;
    Scanner sc = new Scanner(System.in);
    public void arm()
    {
        System.out.print("Please Enter the Number to check ARMSTRONG : ");
        int n = sc.nextInt();
        int a = n;
        while(n > 0)
        {
            int m = n % 10;
            sum += m*m*m;
            n /= 10;
        }

        if(sum == a)
        {
            System.out.println("Number is ARMSTRONG.....");
        }
        else
        {
            System.out.println("Number is NOT ARMSTRONG......");
        }
    }
}

public class demo01
{
    public static void main(String[] args) {
        pattern pt = new pattern();
        pt.arm();
    }   
}