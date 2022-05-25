using System;

class Telefon_konusma_ucreti
{
    static void Main()
    {
        double sure, ucret;

        Console.Write("Telefon konuşma süresi (dk): ");
        sure = Convert.ToDouble(Console.ReadLine());

        if (sure <= 3.0)
            ucret = 0.25;
        else
            ucret = 0.25 + ((sure - 3) * 0.08);

        Console.Write(sure + " dk telefon konuşma ücreti: " + ucret + " Türk Lirası");
        Console.ReadLine();

    }
}