using System;

class unchecked_anahtar_sozcugu
{
    static void Main()
    {
        int i = 256;
        int a = 300;
        byte b, c;
        checked
        {
            b = (byte)i;

            unchecked
            {
                c = (byte)a;
            }
        }
        Console.WriteLine(b);
    }
}