using System;
class For_ornek1
{
    static void Main()
    {
        int adet = 0, toplam = 0;
        for (int i=1; i<=1000; i++)
        {
            if((i%5 ==0) && (i%7!=0))
            {
                Console.WriteLine(i);
                toplam += i;
                adet++;
            }
        }
        Console.WriteLine("{0} sayı bulundu", adet);
        Console.WriteLine("Toplamları= {0}", toplam);
    }
}