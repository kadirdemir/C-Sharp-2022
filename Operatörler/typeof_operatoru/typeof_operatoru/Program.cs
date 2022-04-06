using System;
class Typeof_operatoru
{
    static void Main()
    {
        Type t1 = typeof(Typeof_operatoru);
        Typeof_operatoru den = new Typeof_operatoru();

        Type t2 = den.GetType();

        Console.WriteLine(t1.ToString());
        Console.WriteLine(t2.ToString());
    }
}