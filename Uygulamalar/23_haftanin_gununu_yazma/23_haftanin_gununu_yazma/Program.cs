using System;
class Haftanin_gununu_yazma
{
    static void Main()
    {
        byte gun_no;

    gun_oku:
        Console.Write("Gün numarasını giriniz: ");
        gun_no = Convert.ToByte(Console.ReadLine());

        switch (gun_no)
        {
            case 1: Console.WriteLine("Pazartesi");
                break;
            case 2:
                Console.WriteLine("Salı");
                break;
            case 3:
                Console.WriteLine("Çarşamba");
                break;
            case 4:
                Console.WriteLine("Perşembe");
                break;
            case 5:
                Console.WriteLine("Cuma");
                break;
            case 6:
                Console.WriteLine("Cumartesi");
                break;
            case 7:
                Console.WriteLine("Pazar");
                break;
                default:
                goto gun_oku;
        }
        Console.ReadLine();

    }
}