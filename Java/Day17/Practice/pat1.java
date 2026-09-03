import java.util.Scanner;

class st
{
    Scanner sc = new Scanner(System.in);
    public void star1()
    {
        System.out.print("Please Enter the Number of row : ");
        int n = sc.nextInt();

        for(int i = 0 ; i < n ; i++)
        {
            for(int j = 0 ; j < i ; j++)
            {
                System.out.print("* ");
            }

            System.out.println();
        }
        sc.close();
    }
}

public class pat1
{
    public static void main(String[] args) {
        st s = new st();
        s.star1();
    }
}