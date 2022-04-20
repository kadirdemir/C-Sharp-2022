using System;
class İki_sayidan_buyuk_olani_bulma
{
    static void Main()
    {
        int x, y;

        Console.Write("x: ");
        x = Convert.ToInt32(Console.ReadLine());

        Console.Write("y: ");
        y = Convert.ToInt32(Console.ReadLine());

        if (x > y)
            Console.Write("x büyük");
        else
            Console.Write("y büyük");

        Console.ReadLine();
    }
}