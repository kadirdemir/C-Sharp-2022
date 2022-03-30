using System;
class TurDonusumu4
{
    static void Main()
    {
        byte a = 5;
        byte b = 10;
        byte c = a + b;
        //byte c = a + b; ifadesinde byte yerine int yazılırsa hata düzelir
        //cannot implicitly convert type int to byte
        //int türü byte türüne bilincsiz olarak dönüstürülemedi
        Console.WriteLine(c);
    }
}
