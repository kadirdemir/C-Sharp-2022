using System;
class Yaricap_kontrollu_daire_alani_cevresi
{
    static void Main()
    {
        double r, a, c;
        const double pi = 3.1415;

    r_al:
        Console.Write("Yarıçap: ");
        r= Convert.ToDouble(Console.ReadLine());

        if (r <= 0)
            goto r_al;

        a = pi * r * r;
        c = 2 * pi * r;

        Console.Write("Alan: " + a + "Çevre: " + c);

        Console.ReadLine();
    }
}