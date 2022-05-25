using System;

class Tek_bilinmeyenli_denklem_icice_for
{
    static void Main()
    {
        double x, a, b;

        for(b=1; b<=5; b++)
        {
            for(a=1; a<=5; a++)
            {
                x = -b / a;
                Console.WriteLine("b=" + b + "\t a= " + a + "\t x= " + x);
            }
        }

        Console.ReadLine();
    }
}