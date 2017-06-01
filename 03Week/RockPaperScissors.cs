using System;

namespace _03Week
{

    public class RockPaperScissors
    {
        public void Run()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2:");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));
        }

        public static string CompareHands(string hand1, string hand2)
        {


           
            if (hand1 == hand2)
            {
                return "its a tie";
            }
            else if (hand1 == "scissors")
            {

                if (hand2 == "paper")
                {
                    return "player 1 has won";
                }
                return "player 2 has won";
            }
            else if (hand1 == "rock")
            {

                if (hand2 == "scissors")
                {
                    return "player 1 has won";
                }
                return "player 2 has won";
            }
            else if (hand1 == "paper")
            {

                if (hand2 == "rock")
                {
                    return "player 1 has won";
                }
                return "player 2 has won";
            }
            else
            {
                return "invalid hands";
            }


        }
    }
}

