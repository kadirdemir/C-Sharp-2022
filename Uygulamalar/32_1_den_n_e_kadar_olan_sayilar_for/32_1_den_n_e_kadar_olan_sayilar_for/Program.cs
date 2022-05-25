using System;
class Birden_n_e_kadar_olan_sayilar_for
{
    static void Main()
    {
        int s, n;

        Console.Write("n değeri: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (s = 1; s <= n; s++)
            Console.WriteLine(s);


        Console.WriteLine();

        s = 1;
        while (s <= n)
        {
            Console.WriteLine(s);
            s++;
        }

        Console.ReadLine();


    }
}
