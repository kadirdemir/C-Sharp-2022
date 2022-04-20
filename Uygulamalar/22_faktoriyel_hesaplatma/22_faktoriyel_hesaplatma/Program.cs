using System;
class Faktoriyel_hesaplatma
{
    static void Main()
    {
        int s = 0, f = 1, n;

        Console.Write("n:");
        n =Convert.ToInt32(Console.ReadLine());

    sayac_artirma:
        s = s + 1;

        if(s<=n)
        {
            f = f * s;
            goto sayac_artirma;
        }

        Console.Write(n + "faktöriyel= " + f);

        Console.ReadLine();
    }
}