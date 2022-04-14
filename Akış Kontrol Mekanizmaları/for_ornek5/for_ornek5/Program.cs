using System;
class For_ornek5
{
    static void Main()
    {
        int max = 0, min = 100, toplam = 0;
        int adet = 10;
        int not;

        for (int i = 0; i < adet; )
        {
            Console.Write("Notu giriniz: ");
            not = Convert.ToInt32(Console.ReadLine());

            if (not < 0 || not > 100)
                Console.WriteLine("Yanlış not girildi");
            else
            {
                if (not > max)
                    max = not;
                else if(not < min)
                    min = not;
                toplam += not;
                i++;
            }
        }
        Console.WriteLine("En yüksek not {0}", max);
        Console.WriteLine("En düşük not {0}", min);
        float ortalama = (float) toplam/(float) adet;
        Console.WriteLine("Ortalama {0}", ortalama);
    }
}