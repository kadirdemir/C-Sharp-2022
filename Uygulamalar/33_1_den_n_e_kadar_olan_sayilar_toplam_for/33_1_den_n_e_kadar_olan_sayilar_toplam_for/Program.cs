using System;
class Birden_n_e_kadar_olan_sayilar_toplam_for
{
    static void Main()
    {
        int s, n, top=0;

        Console.Write("n değeri: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (s = 1; s <= n; s++)
            top += s;
        Console.WriteLine("for ile toplam: " + top);


        top = 0;
        s = 1;
        while (s <= n)
        {
            top += s;
            s++;
        }
        Console.WriteLine("while ile toplam: " + top);

        Console.ReadLine();


    }
}

