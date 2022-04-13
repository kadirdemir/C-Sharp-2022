using System;
class Switch_deyimi3
{
    static void Main()
    {
        int sayi1, sayi2;
        string islem;

        Console.Write("Birinci sayıyı giriniz: ");
        sayi1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("İkinci sayıyı giriniz: ");
        sayi2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nToplama---> t");
        Console.WriteLine("\nÇıkarma---> c");
        Console.WriteLine("\nÇarpma---> m");
        Console.WriteLine("\nBölme---> b");

        Console.WriteLine("İşleminizi seçiniz: ");
        islem = Console.ReadLine();

        switch(islem)
        {
            case "t":
                Console.WriteLine("Sonuç: {0}", sayi1 + sayi2);
                break;
            case "m":
                Console.WriteLine("Sonuç: {0}", sayi1 * sayi2);
                break;
            case "c":
                Console.WriteLine("Sonuç: {0}", sayi1 - sayi2);
                break;
            case "b":
                switch(sayi2)
                {
                    case 0:
                        Console.WriteLine("Bölen sıfır olamaz");
                        break;
                    default:
                        float sonuc = (float)sayi1 / (float)sayi2;
                        Console.WriteLine("Sonuç: {0}", sonuc);
                        break;
                }
                break;
        }
    }
}
