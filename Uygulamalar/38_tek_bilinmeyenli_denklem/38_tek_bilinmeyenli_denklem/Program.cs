using System;

class Tek_bilinmeyenli_denklem
{
    static void Main()
    {
        double x, a, b = 1;

        for(a=1; a<=10; a++)
        {
            x = -b / a;
            Console.WriteLine("a= " + a + "\t x= " + x);

        }
        Console.ReadLine();
    }
}