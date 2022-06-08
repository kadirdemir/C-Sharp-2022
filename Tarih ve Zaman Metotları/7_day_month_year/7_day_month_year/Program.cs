using System;

class Day_month_year
{
    static void Main()
    {
        DateTime simdikiTarih = DateTime.Today;
        int gun = simdikiTarih.Day;
        int ay = simdikiTarih.Month;
        int yil = simdikiTarih.Year;

        Console.WriteLine("Bugün ayın {0}{1}", gun, ". günü");
        Console.WriteLine("Bu ay yılın {0}{1}", ay, ". ayı");
        Console.WriteLine("Bugün {0}{1}", yil, " yılındayız.");

        Console.ReadLine();

    }
}