using System;
class Yas_kontrolu
{
    static void Main()
    {
        int yas;

        Console.Write("Yaşınızı giriniz: ");
        yas = Convert.ToInt32(Console.ReadLine());

        if (yas < 18)
            Console.WriteLine("Yaşınız küçük");
        else
        Console.Write("Siteye girebilirsiniz");

        Console.ReadLine();
    }
}