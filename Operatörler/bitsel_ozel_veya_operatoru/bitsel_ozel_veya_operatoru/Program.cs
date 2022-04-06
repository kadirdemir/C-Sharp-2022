using System;

class Bitsel_ozel_veya_operatoru
{
    static void Main()
    {
        byte b = 145;
        byte c = 73;

        Console.WriteLine("İlk Değer: " + c);

        c = (byte)(c ^ b);
        Console.WriteLine("İlk XOR: " + c);

        c = (byte)(c ^ b);
        Console.WriteLine("İkinci XOR: " + c);
    }
}