using System;

namespace AliceWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            //Puts first line of Alice in Wonderland into string
            string firstLine = "Alice was beginning to get very tired of sitting by" +
                "her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no pictures" +
                "or converations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";

            //Describes games to user and askes for input
            Console.WriteLine("Do you remember the first sentence of Alice in Wonderland?");
            Console.WriteLine("Think of a word or phrase that might be in this sentence.\n" +
                "If your guess is correct, you will see 'true'."  +
                "\nIf your guess is wrong, you will see 'false'.");
            Console.WriteLine("To stop the guessing game, please just press the ENTER key.");

            //establishes search term string outside loop to allow for multiple searches
            string toFind;

            //loop created to allow for multiple search terms
            do
            {
                //asks user for search term 
                Console.Write("Please enter your word or phrase: ");
                toFind = Console.ReadLine();

                //breaks loop if user presses enter
                if (toFind == "")
                {
                    Console.WriteLine("The game has ended.");
                    break;
                }

                //changes search term to all lower case for case insensitive search

                else
                {
                    //finds term in string
                    int answer = firstLine.ToLower().IndexOf(toFind.ToLower());

                    //if term is not in string (-1) prints false, if it is prints true
                    string message = (answer != -1) ? "true" : "false";
                    Console.WriteLine(message);
                }

                //allows loops as long as user doesn't press enter
            } while (toFind != "");

               Console.ReadLine();
            
        }
           
     }
 }
    

