using System;

public class object_veri_turu
{
    public static void Main()
    {
        object a;
        a = 5;
        Console.WriteLine(a.GetType());
        a = 'A';
        Console.WriteLine(a.GetType());
        a = 12.5F;
        Console.WriteLine(a.GetType());
        a = true;
        Console.WriteLine(a.GetType());
        a = 3.14M;
        Console.WriteLine(a.GetType());

    }
}
