using System;

class Day_of_year
{
    static void Main()
    {
        DateTime tarih = DateTime.Now;
        string gun1 = tarih.DayOfYear.ToString();
        int gun2 = Convert.ToInt32(tarih.DayOfYear);
        Console.WriteLine("Bugün yılın {0}{1}", gun1, ". günü");
        Console.WriteLine("Bugün yılın {0}{1}", gun2, ". günü");
        Console.ReadLine();
    }
}