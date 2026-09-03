import java.util.Scanner;

class st2
{
    Scanner sc = new Scanner(System.in);
    public void star3()
    {
        System.out.print("Enter the Number of Rows : ");
        int n = sc.nextInt();

        for(int i = 1 ; i <= n ; i++)
        {
            for(int j = 0 ; j < i ; j++)
            {
                System.out.print(i + " ");
            }
            System.out.println();
        }
        sc.close();
    }
}

public class pat3 {
    public static void main(String[] args) {
        st2 s2 = new st2();
        s2.star3();
    }
}
