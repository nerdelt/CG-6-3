using System;

namespace AliceWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLine = "Alice was beginning to get very tired of sitting by" +
                "her sister on the bank, and of having nothing to do: once or twice " +
                "she had peeped into the book her sister was reading, but it had no pictures" +
                "or converations in it, 'and waht is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";

            firstLine = firstLine.ToLower();

            Console.WriteLine("Do you remember the first sentence of Alice in Wonderland?");
            Console.WriteLine("Think of a word or phrase that might be in this sentence.\n" +
                "If your guess is correct, you will see 'true'."  +
                "\nIf your guess is wrong, you will see 'false'.");
            Console.WriteLine("To stop the guessing game, please just press the ENTER key.");

            string toFind;

            do
            {
                Console.Write("Please enter your word or phrase: ");
                toFind = Console.ReadLine();

                if (toFind == "")
                {
                    Console.WriteLine("The game has ended.");
                    break;
                }
                else
                {
                    int answer = firstLine.IndexOf(toFind.ToLower());
                    string message = (answer != -1) ? "true" : "false";
                    Console.WriteLine(message);
                }

            } while (toFind != "");

               Console.ReadLine();
            
           
            
            

  

            
        }
           // private static bool Contains()
        //{

        }
        }
    

