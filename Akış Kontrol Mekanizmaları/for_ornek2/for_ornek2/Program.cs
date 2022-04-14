using System;
class For_ornek2
{
    static void Main()
    {
        int adet = 0;

        for (int i=0; i<=100; i+=5)
        {
            if (adet %6 == 0 )
                Console.WriteLine();
            Console.Write("{0,5}", i);
            adet++;
        }
        Console.WriteLine("\n");
    }
}