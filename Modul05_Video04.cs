using System;

namespace ClassExplorer
{
	public class person
	{
		public string simpleString = "Class text variable";
		public string user = "";
		private string hiddenString = "";


		public person (string _ini)
		{
			if (_ini == "password1") hiddenString = "User1";
			if (_ini == "password2") hiddenString = "User2";

			user = hiddenString;

			if (hiddenString.Lenght > 0 )
				simpleString = "Welcome back"+ user + "!";
			else
				
			simpleString = "You do not have access to this program.";

		}
	}
	class MainClass
	{
		
		public static void Main(string[] args)
		{
			//Class Definition
			person _person = new person();

			//Class access

			Console.WriteLine(_person.simpleString);
		}
	}
}
