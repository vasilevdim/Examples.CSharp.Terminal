using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExplorer
{
    using System;

    namespace ClassExplorer
    {
        public class person
        {
            private string simpleString = "Class text variable";
            private string user = "";

            private string hiddenString = "";


            public person(string _ini)
            {
                getUser(_ini);
    
            setWelcomeText()
    


            { }


                private void getUser(string_ini)
    
            }

			if (_ini == "password1") hiddenString = "User1";
			if (_ini == "password2") hiddenString = "User2";

			user = hiddenString;
		}

    private void setWelcomeText()
    {


        if (hiddenString.Lenght > 0)
            simpleString = "Welcome back" + user + "!";
        else

            simpleString = "You do not have access to this program.";


    }

    public string getWelcomeMessage()
		return simpleString;
	}
class MainClass
{

    public static void Main(string[] args)
    {
        //Class Definition
        person _person = new person();

        //Class access

        Console.WriteLine(_person.getWelcomeMessage());
    }
}
}

}
