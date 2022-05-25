using System;

class Mil_km_cevirici
{
    static void Main()
    {
        const float oran = 1.609344F;

        string sec;

        double mesafe, sonuc;

        Console.Write("Mil (M/m) veya Kilometre (K/k) seçiniz: ");
        sec = Convert.ToString(Console.ReadLine());

        if ((sec == "M") || (sec == "m"))
        {
            Console.Write("Kaç mil yol aldınız: ");
            mesafe = Convert.ToDouble(Console.ReadLine());
            sonuc = mesafe * oran;
            Console.Write(mesafe + " Mil = " + sonuc + " Kilometre");
            Console.ReadLine();
        }
        else if ((sec == "K") || (sec == "k"))
        {
            Console.Write("Kaç km yol aldınız: ");
            mesafe = Convert.ToDouble(Console.ReadLine());
            sonuc = mesafe / oran;
            Console.Write(mesafe + " Kilometre = " + sonuc + " Mil");
            Console.ReadLine();
        }
    }
}