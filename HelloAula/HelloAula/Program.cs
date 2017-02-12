using System;

namespace HelloAula
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello Aula!");
			int a = 0;
			int b = 0;
			int sum = 0;
			a = 10;
			b = 10;
			sum = a + b;
			Console.Write(a);
			Console.Write("+");
			Console.Write(b);
			Console.Write("=");
			Console.WriteLine(sum);
			//Additional Operands
			Console.WriteLine("\nUse of +=");
			a += b;
			Console.WriteLine(a);
			Console.WriteLine("\nUse of -=");
			a -= b;
			Console.WriteLine(a);
			Console.WriteLine("\nUse of ++");
			a ++;
			Console.WriteLine(a);
			Console.WriteLine("\nUse of *=");
			a *= b;
			Console.WriteLine(a);
			Console.WriteLine("Standartno delene" + (7/4).ToString());
			Console.WriteLine("Ostatak ot delene" + (7 % 4).ToString());
			}
	}
}
