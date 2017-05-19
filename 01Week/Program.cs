using System;
using System.Text;

namespace ConsoleApplication
{
    
    class Program
    {
        static void Main(string[] args)
        {



            // We have created a new Person.
            Person person = new Person();

            // Add the values of the properties that define that new person.
            Console.WriteLine("Enter the first name");
            person.firstName = Console.ReadLine();

            Console.WriteLine("Enter the last name");
            person.lastName = Console.ReadLine();

            Console.WriteLine("Enter the favorite team");
            person.favoriteTeam = Console.ReadLine();

            Console.WriteLine("Enter the ethnicity");
            person.ethnicity = Console.ReadLine();

            Console.WriteLine("Enter the gender");
            person.gender = Console.ReadLine();

            Console.WriteLine(DatingProfile(person));

        }




        public static string DatingProfile(Person person)
        {
            StringBuilder strDescription = new StringBuilder("{0} likes to hike in the outdoors. His favorite team is the {1}. Ethniciy is {2}");

            // string strDescription = "{0} likes to hike in the outdoors. His favorite team is the {1}. Ethniciy is {2}";

            if (person.favoriteTeam == "spurs")
            {
                strDescription.Append(" GO SPURS GO!");
            }
            else
            {
                strDescription.Append(" ROcKets RoCk!!");
            }


            return string.Format(strDescription.ToString(), person.firstName, person.favoriteTeam, person.ethnicity);
        }








        public static int Add(int number1, int number2)
        {
            //Begin the add process 
            return number1 + number2;
            // total = number1 + number2; 
            // Console.WriteLine("Your total is: " + total);

        }

        public static double ConvertYardsToInches(int number1)
        {
            return number1 * 36.000;
        }

        public static void EnterName()
        {
            // Declare your variables 
            string strUserInput = "";

            //Ask the user if their name is correct
            Console.WriteLine("Hello John, Please type a new name.");
            strUserInput = Console.ReadLine();

            //Output value to terminal 
            Console.WriteLine("Hello, " + strUserInput);
        }
    }
}

            // Declare out datatypes 
            // int number1 = 0;
            // int number2 = 0;

            //Ask user for the initial values 
            //first value 
            // Console.WriteLine("Please enter the first value");
            // number1 = Convert.ToInt32(Console.ReadLine());

            // second value 
            // Console.WriteLine("Please enter the second value");
            // number2 = Convert.ToInt32(Console.ReadLine());


            // // Calling Add function 
            // Console.WriteLine(Add(number1, number2));

            // // Calling the EnterName function 
            // EnterName();
            // Console.WriteLine(ConvertYardsToInches(number1));



            // string strFirstName, strLastName, strFavoriteTeam, strEthnicity;

            // Console.WriteLine("Enter first name: ");
            // strFirstName = Console.ReadLine();

            // Console.WriteLine("Enter last name: ");
            // strLastName = Console.ReadLine();

            // Console.WriteLine("Enter favorite sports team: ");
            // strFavoriteTeam = Console.ReadLine();

            // Console.WriteLine("Enter ethnicity: ");
            // strEthnicity = Console.ReadLine();

            // Console.WriteLine(DatingProfile(strFirstName, strLastName, strFavoriteTeam, strEthnicity));

            // }
