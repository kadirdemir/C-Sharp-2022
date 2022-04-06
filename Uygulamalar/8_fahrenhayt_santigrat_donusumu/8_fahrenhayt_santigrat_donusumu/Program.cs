using System;

class Fahrenhayt_santigrat_donusumu
{
    static void Main()
    {
        double c, f;
        Console.Write("Fahrenhayt değeri: ");
        f = Convert.ToDouble(Console.ReadLine());
        c = (f - 32) / 1.8;
        Console.Write("Fahrenhayt: " + f + " Santigrat: " + c);
        Console.ReadLine();

    }
}