using System;

class Kucuk_buyuk_operatörü
{
    static void Main()
    {
        bool b1 = 60 < 50;
        bool b2 = 50 < 60;
        bool b3 = 20.54 > 65.7;
        bool b4 = 10.4f > 5.4;

        Console.WriteLine("{0}\n{1}\n{2}\n{3}\n", b1, b2, b3, b4);
    }
}