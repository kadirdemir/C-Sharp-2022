using System;
class While_dongusu2
{
    static void Main()
    {
        int n = 0;
        int toplam = 0;

        while (n<=100)
        {
            toplam += n;
            n += 2;
        }
        Console.WriteLine(toplam);
    }
}