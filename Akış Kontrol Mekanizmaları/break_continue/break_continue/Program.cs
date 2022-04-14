using System;
class Break_continue
{
    static void Main()
    {
        int sayi;
        int toplam = 0;
        int bironcekisayi = 0;

        //for (;;) ifadesi sonsuz döngü için kullanılır
        for(;;)
        {
            Console.Write("Bir sayı giriniz: ");
            sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi == 0)
                break;

            if (sayi == bironcekisayi)
            {
                Console.WriteLine("Farklı sayı giriniz: ");
                continue;
            }

            toplam += sayi;
            Console.WriteLine("Toplam ={0}", toplam);
            bironcekisayi = sayi;
        }
        Console.WriteLine("Döngü bitti...");

    }
}