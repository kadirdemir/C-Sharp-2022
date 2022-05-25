using System;
class Faktoriyel_for_while
{
    static void Main()
    {
        int n, f = 1;

        Console.Write("n değeri: ");
        n = Convert.ToInt32(Console.ReadLine());

        for (int s = 1; s <= n; s++)
            f*=s;
        Console.WriteLine("for ile " + n + "!= " +f);

        int say = 1;
        f = 1;

        while (say <= n)
        {
            f *= say;
            say++;
        }
        Console.WriteLine("while ile " + n + "!= " + f);

        Console.ReadLine();


    }
}


