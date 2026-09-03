import java.util.Scanner;

class st1
{
    Scanner sc = new Scanner(System.in);
    public void star2()
    {
        System.out.print("Enter the Number of rows : ");
        int n = sc.nextInt();

        for(int i = n ; i > 0 ; i--)
        {
            for(int j = i ; j > 0 ; j--)
            {
                System.out.print("* ");
            }
            System.out.println();
        }
        sc.close();
    }
}

public class pat2 {
    public static void main(String[] args) {
        st1 s1 = new st1();
        s1.star2();
    }
}
