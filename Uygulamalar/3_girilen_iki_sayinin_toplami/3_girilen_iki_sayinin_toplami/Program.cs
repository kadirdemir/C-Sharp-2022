using System;

class Program
{

	static void Main()
	{
		int s1, s2;
		int topla;

		Console.Write("İlk sayıyı giriniz: ");
		s1 = Convert.ToInt32(Console.ReadLine());

		Console.Write("İkinci sayıyı giriniz: ");
		s2 = Convert.ToInt32(Console.ReadLine());

		topla = (s1 + s2);

		Console.WriteLine("İki sayı toplamı: " + topla);
		Console.Read();
	}
}