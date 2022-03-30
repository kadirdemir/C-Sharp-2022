using System;

class checked_anahtar_sozcugu_blok
{
    static void Main()
    {
        int i = 256;

        checked
        {
            byte b = (byte)i;
        }
        Console.WriteLine(b);
    }
}
