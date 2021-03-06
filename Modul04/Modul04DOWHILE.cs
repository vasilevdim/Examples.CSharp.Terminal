using System;

namespace Modul04
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			string[,] _table = {
			{ "Ivan",   "Georgiev",    "19" },
			{ "Ivan",   "Georgiev",    "23" },
			{ "Vasil", "Georgiev",     "58" },
			{ "Milen", "Georgiev",     "14" },
			{ "Tsvetan", "Borislavov", "25" },
			{ "Gergana", "Vasileva",   "23" }
			};
			Console.WriteLine("Ime".PadRight(12) + "Family".PadRight(12) + "Age".PadRight(12));
			Console.WriteLine("===========================================================");

			//"While" Example
			//int i = 0;
			//while (i < _table.Length/3)
			//{
				//Console.WriteLine(_table[i,0].PadRight(12) + _table[i,1].PadRight(12) + _table[i,2].PadRight(12));
				//i++;
			//}
			//Example with "Do...while"
			int i = 0;
			do
			{Console.WriteLine(_table[i, 0].PadRight(12) + _table[i, 1].PadRight(12) + _table[i, 2].PadRight(12));
				i++;


			} while (i < _table.Length / 3);


		}
	}
}

