using System;

namespace Modul05
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//Definition
			string usercommand = "";


			//User's commands
			do
			{
				Console.Write("$ "); usercommand = Console.ReadLine();
				if (usercommand.Contains("cmd01")) cmd01 (usercommand);
				//if (usercommand.Contains("cmd02")) Console.WriteLine(cmd02(usercommand));
				//if (usercommand.Contains(cmd03))
				//{
					//double _a = 0;
					//if (cmd03(usercommand, out_a))
					//	Console.WriteLine("a.a" + _a.ToString());
				//}

			} while (usercommand != "exit");
		}
		//To be executed only
		public static void cmd01(string _input)//test 5>5^2
		{
			try
			{

				double _temp = 0;
				if (double.TryParse(_input.Split(' ')[1], out _temp))
				{
					Console.WriteLine("\nResult from " + _temp.ToString() + "^2 = " + (_temp * _temp).ToString());
				}

			}
			catch { }
		}

			else {
						Console.WriteLine("The command has not been entered correctly");
					}
				}
			}

			
		



//		public static int cmd02 (string _input)
//		{


//			int _temp = 0;
//			if (int.TryParse(_input.Split(' ')[1], out _temp)) ;
//			{
//				_temp = _temp * _temp * _temp;

//				return _temp;
//			}
//			//To output parameters
//		}
//	}
//}
////public static bool cmd03 (string _input, out double _i)
////{
////	try
////	{
////		string _p = _input.Split(' ')[1];
////		double _p = 0;
////		if (double.TryParse(_p, out _p))


////			i = _p * _p;
////		return true;


//	}
//	catch
//	{

//	}

//	if( i = 0);

//	return false;
//}
//public static bool cmd03 (string _input, out double _i)
//{
//	try
//	{
//		string _p = _input.Split(' ')[1];
//		double _p = 0;
//		if (double.TryParse(_p, out _p))


//			i = _p * _p;
//		return true;


	
//	}catch{


//	}

//	if (i = 0) ;

//	return false;
//}


