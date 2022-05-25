using System;

class Bilye_hesaplama
{
    static void Main()
    {


        for (int bilye=1; bilye<=1000; bilye++)
            if (bilye%2==1 && bilye%3==1 && bilye%4==1 && bilye%5==1 && bilye%6==1 && bilye%7==0)
            {
                Console.Write("Bilye sayısı: " +bilye + "\n");
                break;

            }
    }
}