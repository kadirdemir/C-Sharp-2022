using System;
class Iki_deger_arasi_yazdir
{
    static void Main()
    {
        int x, y;

        Console.Write("x değeri: ");
        x = Convert.ToInt32(Console.ReadLine());


        Console.Write("y değeri: ");
        y = Convert.ToInt32(Console.ReadLine());

        for (; x <= y; x++)
            Console.WriteLine(x);

        Console.ReadLine();
    }
}