using System;

class Dairenin_alani_ve_cevresi
{
    public static void Main()
    {
        double r, a, c;
        const double pi = 3.14;
        Console.Write("Yarıçap: ");
        r = Convert.ToDouble(Console.ReadLine());
        a = pi * r * r;
        c = 2 * pi * r;
        Console.Write("Alan= " + a + " Çevre: " + c);
        Console.ReadLine();
    }
}