using System;

namespace Module02
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Definirane na promenlivi
			int a = 0;
			int b = 0;
			int sum = 0;
			//Sabirane na chisla
			a = 5;
			b = 10;
			sum = a + b;
			//Pisane v consola
			Console.Write(a);
			Console.Write("+");
			Console.Write(b);
			Console.Write("=");
			Console.WriteLine(sum);
			Console.ReadKey();

		}
	}
}
