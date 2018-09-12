using System;

namespace AliceInWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting the string, with concatenation
           string Alice = " Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, ‘and what is the use of a book,’ thought Alice" +
                " ‘without pictures or conversation?’";

            //telling complier to print above string
            Console.WriteLine(Alice);

            //asking user to input a word or words 
            Console.WriteLine(" Please search a word or a phrase from the above read");

            //telling compiler to string what was typed in
            string SearchedText = Console.ReadLine();

            //declaring a varible and prompting the system to accept the searched word(s)
            //whether in CAPS or lower case. 
            var Text = Alice.ToUpper().IndexOf(SearchedText.ToUpper());

            //prompting to print whether the 'searchedtext' is true (found) or false (not found)
            if (Text >= 0)
            {
                Console.WriteLine("Found!");
            }
            else
            {
                Console.WriteLine("Sorry, not found.");
            }
            

            Console.ReadLine();
       










        }
    }
}
