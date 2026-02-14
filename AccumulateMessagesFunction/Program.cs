//Kyson Hensley
//RCET2265
//Spring 2026
//AccumulateMessagesFunction Program
//https://github.com/kysonhensley/AccumulateMessagesFunction.git

using System.Xml.Schema;

namespace AccumulateMessagesFunction
{
    internal class Program
    {
        /*
        // TODO [x]: Define a function that takes a string message and appends it to a accumulating result
        // TODO [x]: Initialize an empty string to hold accumulated messages
        // TODO [x]: Create a loop to allow user to enter multiple messages
        // TODO [x]: Add logic to stop the loop when user chooses to stop
        // TODO [x]: Display the accumulated messages at the end
        // TODO []: Wait for user to press Enter before closing the console window
        */
        
        static void Main(string[] args)
        {
            // define new variable to hold accumulated messages
            string accumulatedMessages = "";
            string message = "";
            // boolean variable to determine of user has decided to quit
            bool userQuit = true;

            // while loop to allow user to enter multiple messages until they choose to quit
            while (userQuit)
            {
                Console.WriteLine("Enter a message to accumulate or type 'quit' to stop and show accumulated messages:");
                // read user input
                message = Console.ReadLine();
                // check if user wants to quit
                if (message.ToLower() == "quit")
                {
                    userQuit = false;
                }
                // if user hasnt quit, accumulate the message
                else
                {
                    accumulatedMessages = AccumulateMessages(message, accumulatedMessages);
                }
            }
            Console.Clear();
            Console.WriteLine($"You entered the following messages: \n{accumulatedMessages}"); 
            Console.ReadLine();
        }

        static string AccumulateMessages(string message, string accumulatedMessages)
        {
            return accumulatedMessages + message + "\n";
        }
    }
}
