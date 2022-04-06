using System;

class Inch_cm_donusumu
{
    static void Main()
    {
        double i, cm;
        const double oran = 2.54;

        Console.Write("Inch değeri: ");
        i = Convert.ToDouble(Console.ReadLine());

        cm = oran * i;

        Console.Write(i + " inch " + cm + " cm");

        Console.ReadLine();
    }
}