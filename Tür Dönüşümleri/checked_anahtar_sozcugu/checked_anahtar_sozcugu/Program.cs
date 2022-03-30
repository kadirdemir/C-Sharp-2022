using System;

class checked_anahtar_sozcugu
{
    static void Main()
    {
        int i = 256;
        byte b;
        checked
        {
            b = (byte)i;
        }
        Console.WriteLine(b);
    }
}