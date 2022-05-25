using System;
class N_adet_sayi_ortalamasi
{
    static void Main()
    {
        int s, n, sayi, top = 0;

        Console.Write("n değeri: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (s = 1; s <= n; s++)
        {
            Console.Write(s + ". sayı:");
            sayi = Convert.ToInt32(Console.ReadLine());
            top += sayi;
        }
        Console.WriteLine("for ile ortalama: " + top/n);


        top = 0;
        s = 1;
        while (s <= n)
        {
            Console.Write(s + ". sayı:");
            sayi = Convert.ToInt32(Console.ReadLine());
            top += sayi;
            s++;
        }
        Console.WriteLine("while ile ortalama: " + top / n);

        Console.ReadLine();


    }
}


