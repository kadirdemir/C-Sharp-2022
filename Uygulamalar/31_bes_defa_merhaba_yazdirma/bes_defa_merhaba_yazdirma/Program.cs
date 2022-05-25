using System;
class Bes_defa_merhaba_yazdirma
{
    static void Main()
    {
        int s = 1;
    yaz:
        Console.WriteLine("Merhaba (if)");
        s = s + 1;
        if (s <= 5) goto yaz;

        Console.WriteLine();

        for (s = 1; s <= 5; s++)
            Console.WriteLine("Merhaba (for)");
        Console.WriteLine();

        s = 1;
        while(s <= 5)
        {
            Console.WriteLine("Merhaba (while)");
            s++;
        }

        Console.ReadLine();


    }
}