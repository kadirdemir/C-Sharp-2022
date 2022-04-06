using System;

class Bitsel_veya_operatoru
{
    static void Main()
    {
        byte a = 145;
        byte b = 73;
        int c = (byte)(a | b);

        Console.WriteLine(c);
    }
}