import java.util.Scanner;

class Reverse
{
    Scanner sc = new Scanner(System.in);
    int sum = 0;

    public void revNumber()
    {
        System.out.print("Enter the Number : ");
        int n = sc.nextInt();
        while(n != 0)
        {
            int m = n % 10;
            sum = (sum * 10) + m;
            n /= 10; 
        }

        System.out.println("Reversed Number = " + sum);
    }

    public void rev()
    {
        System.out.print("Enter the Number : ");
        int n = sc.nextInt();
        StringBuffer sb = new StringBuffer(String.valueOf(n));
        StringBuffer rev = sb.reverse();

        System.out.println("Reverse Number is : "+rev);
    }

    public void rev1()
    {
        System.out.print("Enter the Number : ");
        int n = sc.nextInt();
        StringBuilder sb = new StringBuilder();
        sb.append(n);

        StringBuilder rev = sb.reverse();

        System.out.println("Reverse Number is : "+rev);
    }
}

public class demo04 {
    public static void main(String[] args) {
        Reverse rev = new Reverse();
        rev.revNumber();
        rev.rev();
        rev.rev1();
    }
}
