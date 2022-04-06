using System;
class Mantiksal_ve_operatoru
{
    static void Main()
    {
        bool b1 = 35 < 10 && 10 == 50; 
        bool b2 = 35 > 10 && 10 != 50;
        bool b3 = 14.6f > 10f && 0 != 100;

        Console.WriteLine(b1);
        Console.WriteLine(b2);
        Console.WriteLine(b3);
        
    }
}