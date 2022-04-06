using System;

class Tek_bilinmeyenli_denklem_cozumu
{
    static void Main()
    {
        //ax+b=0 şeklindeki tek bilinmeyenli denklem çözümü
        //bilinmeyen x
        double a, b, x;

        Console.WriteLine("ax + b = 0 şeklindeki tek bilinmeyenli denklem çözümü");

        Console.Write("a: ");

        a = Convert.ToDouble(Console.ReadLine());

        Console.Write("b: ");
        b = Convert.ToDouble(Console.ReadLine());

        x = -b / a;

        Console.Write("x= " + x);

        Console.ReadLine();
    }
}