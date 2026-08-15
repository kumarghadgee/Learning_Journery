import java.util.Scanner;

class neon
{
    Scanner sc = new Scanner(System.in);
    int sum = 0;
    public void neo()
    {
        System.out.print("Please Enter Number to check is it NEON : ");
        int n = sc.nextInt();

        int a = n * n;

        while(a > 0)
        {
            int m = a % 10;
            sum = sum + m;
            a /= 10;
        }

        if(sum == n)
        {
            System.out.println("Number is NEON........");
        }
        else
        {
            System.out.println("Number is NOT NEON.........");
        }
    }
}

public class demo02 {
    public static void main(String[] args) {
        neon ne = new neon();
        ne.neo();
    }
}
