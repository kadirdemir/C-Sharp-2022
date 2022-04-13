using System;
class If_deyimi2
{
    static void Main()
    {
        int a = 5;
        int b = 7;
        //Bir koşul altında birden fazla işlem yapmak için { } blok içine istenilen kadar deyim yazılabilir.
        if (a<b)
        {
            a++;
            Console.WriteLine("1. Deyim");
            Console.WriteLine(a);
        }
        else
        {
            b--;
            Console.WriteLine("2. Deyim");
            Console.WriteLine(b);
        }
    }
}