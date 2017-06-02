using System;


namespace _03Week
{
    public class Mastermind
    {
        // possible letters in code
        public static char[] letters = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

        // size of code
        public static int codeSize = 4;

        // number of allowed attempts to crack the code
        public static int allowedAttempts = 10;

        // number of tried guesses
        public static int numTry = 0;

        // solution
        // public static char[] solution = new char[] {'a', 'b', 'c', 'd'};
        public static char[] solution = new char[codeSize];

        // game board
        public static string[][] board = new string[allowedAttempts][];


        public void Run()
        {
            CreateBoard();
            DrawBoard();
            GenerateRandomCode();
            char[] guess = new char[4];

            while (numTry < allowedAttempts)
            {
                Console.WriteLine("Enter Guess:");
                guess = Console.ReadLine().ToCharArray();
                if (CheckSolution(guess))
                {
                    return;
                }
                InsertCode(guess);
                board[numTry][codeSize] = GenerateHint(guess);
                numTry++;
                DrawBoard();
            }
            Console.WriteLine("The correct answer was " + String.Join("", solution));
            return;
        }

        public static void GenerateRandomCode()
        {
            Random rnd = new Random();
            for (var i = 0; i < codeSize; i++)
            {
                solution[i] = letters[rnd.Next(0, letters.Length)];
            }

            String answer = "";
            foreach(var letter in solution)
            {
                answer += letter;
            }
            Console.WriteLine("Hey buddy, the answer is {0}. ",answer);
            
            return;
        }

        public static void InsertCode(char[] guess)
        {
            for (var i = 0; i < codeSize; i++)
            {
                board[numTry][i] = guess[i].ToString();
            }
            return;
        }

        public static void CreateBoard()
        {
            for (var i = 0; i < allowedAttempts; i++)
            {
                board[i] = new string[codeSize + 1];
                for (var j = 0; j < codeSize + 1; j++)
                {
                    board[i][j] = " ";
                }
            }
            return;
        }

        public static void DrawBoard()
        {
            for (var i = 0; i < board.Length; i++)
            {
                Console.WriteLine("|" + String.Join("|", board[i]));
            }

            return;
        }

        public static bool CheckSolution(char[] guess)
        {
            if (String.Join("", guess) == String.Join("", solution))
            {
                Console.WriteLine("You Win! " + String.Join("", solution) + " is the solution!");
                return true;
            }
            return false;
        }

        public static string GenerateHint(char[] guess)
        {
            int correctLetterLocations = 0;
            char[] solutionClone = (char[])solution.Clone();

            // write a loop that loops over each item
            // in solutionArray
            for (var i = 0; i < solutionClone.Length; i++)
            {
                // if solution at index i is equal to
                // guess at index i, then increment correctLetterLocations,
                // and cancel out solutionArra at that index
                if (solution[i] == guess[i])
                {
                    correctLetterLocations++;
                    solutionClone[i] = ' ';
                }
            }

            var correctLetters = 0;
            for (var i = 0; i < solutionClone.Length; i++)
            {
                // if solution array contains guessArray at index i,
                // increment correctLetters and cancel out index i of
                // solutionArray

                // must save the index just in case it does exist
                int targetIndex = Array.IndexOf(solutionClone, guess[i]);
                if (targetIndex > -1)
                {
                    correctLetters++;
                    // so that we can "target" it for removal
                    solutionClone[targetIndex] = ' ';
                }
            }

            return correctLetterLocations + " - " + correctLetters;
        }
    }
}