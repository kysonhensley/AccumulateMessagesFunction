using System.Xml.Schema;

namespace AccumulateMessagesFunction
{
    internal class Program
    {
        /*
        // TODO []: Define a function that takes a string message and appends it to a accumulating result
        // TODO []: Initialize an empty string to hold accumulated messages
        // TODO []: Create a loop to allow user to enter multiple messages
        // TODO []: Add logic to stop the loop when user chooses to stop
        // TODO []: Display the accumulated messages at the end
        // TODO []: Wait for user to press Enter before closing the console window
        */
        
        static void Main(string[] args)
        {
            // define new variable to hold accumulated messages
            string accumulatedMessages = "";

            Console.WriteLine("Hello, World!"); 
        }

        static string AccumulateMessages(string message, string accumulatedMessages)
        {
            // TODO []: Append the new message to the accumulated messages
            return accumulatedMessages + message + "\n";
        }
    }
}
