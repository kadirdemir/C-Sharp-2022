using System;
class Switch_deyimi2
{
    static void Main()
    {
        int a = 2;

        switch (a)
        {
            case 1:
            case 2:
                Console.WriteLine("Case1 ve Case2");
                break;
            case 3:
                Console.WriteLine("Case3");
                break;
            default:
                break;
        }
    }
}