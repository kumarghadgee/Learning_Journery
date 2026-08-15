
class swap
{
    public void swap1()
    {
        System.out.println();
        System.out.println("SWAP1");
        int a = 10;
        int b = 20;

        System.out.println("Numbers Before Swap = a = "+a + " , b = " +b );

        a = a + b;
        b = a - b;
        a = a - b;

        System.out.println("Numbers After Swap = a = "+a + " , b = " +b );
    }

    public void swap2()
    {
        System.out.println();
        System.out.println("SWAP2");
        int a = 10;
        int b = 20;

        System.out.println("Numbers Before Swap = a = "+a + " , b = " +b );

        a = a * b;
        b = a / b;
        a = a / b;

        System.out.println("Numbers After Swap = a = "+a + " , b = " +b );
    }

    public void swap3()
    {
        System.out.println();
        System.out.println("SWAP3");
        int a = 10;
        int b = 20;

        System.out.println("Numbers Before Swap = a = "+a + " , b = " +b );

        a = a ^ b;
        b = a ^ b;
        a = a ^ b;

        System.out.println("Numbers After Swap = a = "+a + " , b = " +b );
    }

    public void swap4()
    {
        System.out.println();
        System.out.println("SWAP4");
        int a = 10;
        int b = 20;

        System.out.println("Numbers Before Swap = a = "+a + " , b = " +b );

        b = a+b - (a=b);

        System.out.println("Numbers After Swap = a = "+a + " , b = " +b );
    }
}

public class demo03 {
    public static void main(String[] args) {
        swap sp = new swap();
        sp.swap1();
        sp.swap2();
        sp.swap3();
        sp.swap4();
    }
}
