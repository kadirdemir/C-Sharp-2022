using System;

class Is_operatörü
{
    static void Main()
    {
        int i = 50;
        bool b1 = i is int;
        bool b2 = i is double;
        bool b3 = i is float;

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
    }
}