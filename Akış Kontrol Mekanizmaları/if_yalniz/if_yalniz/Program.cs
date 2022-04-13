using System;
class If_yalniz
{
    static void Main()
    {
        int a = 5;
        int b = 5;
        //koşul doğru ise işlemler yapılır, yanlış ise if blogu dışına çıkılır
        if (a<b)
        {
            a++;
            Console.WriteLine("1. Deyim");
        }
    }
}