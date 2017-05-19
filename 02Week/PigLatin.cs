using System;

namespace ConsoleApplication
{
    public class PigLatin
    {
        public void Run()
        {
            Console.WriteLine("What's the word?");
            string word = Console.ReadLine();
            Console.WriteLine(translateWord(word));
        }

        public static string translateWord(string word)
        {
        //equal

            word = word.ToLower();
            int vowelIndex = word.IndexOf('a'); //3

            if ( (word.IndexOf('e') > -1) && (word.IndexOf('e') < vowelIndex) || (vowelIndex == -1) )
{
            vowelIndex = word.IndexOf('e');
        

}
            if ( (word.IndexOf('i') > -1) && (word.IndexOf('i') < vowelIndex) || (vowelIndex == -1) ) {

            vowelIndex = word.IndexOf('i'); 
            }

            if ( (word.IndexOf('o') > -1) && (word.IndexOf('o') < vowelIndex) || (vowelIndex == -1) ) {

            vowelIndex = word.IndexOf('o'); 
            }
            if ( (word.IndexOf('u') > -1) && (word.IndexOf('u') < vowelIndex) || (vowelIndex == -1) ) {

            vowelIndex = word.IndexOf('u'); 
            }

            string firstPart = word.Substring(0, vowelIndex);
            string restWord = word.Substring(vowelIndex, word.Length - 1);
// 1
            Console.WriteLine("vowelIndex: " + vowelIndex);

            //hellow substring(0,1) == h
            Console.WriteLine("firstPart: " + firstPart);
            Console.WriteLine("restWord: " + restWord);
            Console.WriteLine(vowelIndex);





            Console.WriteLine(vowelIndex);

           

            return "Pig Latin Word: " + restWord + firstPart + "ay";
        }

    }
}
