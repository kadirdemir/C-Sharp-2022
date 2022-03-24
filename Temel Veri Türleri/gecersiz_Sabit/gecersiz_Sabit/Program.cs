using System;

public class sabitler4
{
    public static void Main()
    {
        const int a = 3;
        a = a + 1; // a artık sabit değil
        const int b = a + 5;
        Console.WriteLine(b);
    }
}
