using System;
class Dikdortgenin_alani_ve_cevresi
{
	static void Main()
	{
		double g, y, a, c;

		Console.Write("Genişliği giriniz: ");
		g = Convert.ToDouble(Console.ReadLine());

		Console.Write("Yüksekliği giriniz: ");
		y = Convert.ToDouble(Console.ReadLine());

		a = g * y;
		c = 2 * g + 2 * y;

		Console.WriteLine("Alanı = " + a + " ve Çevresi = " + c);
		Console.Read();
	}
}
