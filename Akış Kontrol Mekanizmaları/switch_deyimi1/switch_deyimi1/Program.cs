using System;
class Switch_deyimi1
{
    static void Main()
    {
        int a = 1;

        switch (a)
        {
            case 1:
                Console.WriteLine("Case1");
                goto case 2;
            case 2:
                Console.WriteLine("Case2");
                break;
            default:
                break;
        }
    }
}