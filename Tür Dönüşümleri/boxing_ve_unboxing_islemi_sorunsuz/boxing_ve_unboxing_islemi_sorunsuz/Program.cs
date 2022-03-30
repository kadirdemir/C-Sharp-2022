using System;

class boxing_ve_unboxing_islemi_sorunsuz
{
    static void Main()
    {
        int i = 10;
        object o = i;

        int j = (int)o;

        Console.WriteLine(i);
        Console.WriteLine(j);
    }
}