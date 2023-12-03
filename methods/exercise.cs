using System;

public class Methods
{
    public static void Main()
    {

        int x = 2;
        int y = 2;
        int a = Foo(x,y);
        Console.WriteLine(a);

    }

    public static int Foo(int a, int b) {
        return (a/b);
    }
}
