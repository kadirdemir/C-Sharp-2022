using System;

class Maxvalue_minvalue
{
    static void Main()
    {
        DateTime altLimit = DateTime.MinValue;
        DateTime ustLimit = DateTime.MaxValue;
        Console.WriteLine("Program için verilebilen en alt tarih bilgisi: {0}", altLimit);
        Console.WriteLine("Program için verilebilen en üst tarih bilgisi: {0}", ustLimit);
        Console.ReadLine();

    }
}