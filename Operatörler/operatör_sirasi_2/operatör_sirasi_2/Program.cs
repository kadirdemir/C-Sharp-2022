using System;

class Operatör_sirasi_2
{
    static void Main()
    {
        int c = (2 + (9 + 2) * 5) * 2;
        Console.WriteLine("C = (2 + (9 + 2) * 5) * 2 = " + c);

        int d = 2 + 9 + 2 * 5 * 2;
        Console.WriteLine("D = 2 + 9 + 2 * 5 * 2 = " + d);

        int e = 2 + (9 + 2 * 5) * 2;
        Console.WriteLine("E = 2 + (9 + 2 * 5) * 2 = " + e);
    }
}