using System;

class boxing_ve_unboxing_islemi_sorunlu
{
    static void Main()
    {
        int i = 10;
        object o = i;

        int j = (byte)o;

        Console.WriteLine(i);
        Console.WriteLine(j);
    }
}
