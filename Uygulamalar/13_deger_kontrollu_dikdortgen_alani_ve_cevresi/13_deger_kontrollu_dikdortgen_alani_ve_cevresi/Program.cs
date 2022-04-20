using System;
class Deger_kontrollu_dikdortgen_alani_ve_cevresi
{
    static void Main()
    {
        double a, c, g, y;

    g_oku:
        Console.Write("Genişlik: ");
        g = Convert.ToDouble(Console.ReadLine());
        if (g <= 0) goto g_oku;

        y_oku:
        Console.Write("Yükseklik: ");
        y = Convert.ToDouble(Console.ReadLine());
        if (y <= 0) goto y_oku;

        a = g * y;
        c = 2 * (g + y);

        Console.Write("Alan= " + a + " Çevre= " + c);

        Console.ReadLine();
    }
}