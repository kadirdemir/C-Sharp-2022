using System;
class If_deyimi1
{
    static void Main()
    {
        int a = 5;
        int b = 7;
        //değer true ise 1. deyim, false ise 2. deyim çalıştırılır
        if (a < b)
            Console.WriteLine("1. Deyim");
        else
            Console.WriteLine("2. Deyim");
    }
}