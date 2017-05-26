using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class MyNewList
    {


        public void Run()
        {


            List<string> people = new List<string>();

            Console.WriteLine("Please enter 4 Names: ");

            while (people.Count < 3)
            {

                var input = Console.ReadLine();


                if (!people.Contains(input))
                {
                    people.Add(input);
                }

                else
                {
                    Console.WriteLine("Name is already on the List");
                    Console.WriteLine("Would you like to remove the name?");
                    
                    var response = Console.ReadLine();
                    if ( response == "y") {
                        people.Remove(input);
                        Console.WriteLine("Continued adding names");

                    }


                }
            }

            Console.WriteLine("This is who your team is:");
            people.ForEach(Console.WriteLine);
        }



        //Ask the user for 10 names and add into the list

        //Count
        //Console.ReadLine();
        //List<string> people
        //people.Add();


    }

}