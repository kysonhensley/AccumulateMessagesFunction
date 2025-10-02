namespace AccumulateMessagesFunction
{
    internal class Program


    {

        private static string _messages = "";

        static void TestMessages()
        {
            Messages("first message");
            Messages("second message");
            Messages("third message");
            Messages(" "); //should be ignored  
            Console.WriteLine(Messages());
        }
        static void Main(string[] args)
        {
            string userMessage = "this is important";
            bool userHasQuit = false;

            //TestMessages();

            do
            {
                userMessage = Console.ReadLine();
                //check for quit
                if (userMessage == "q" || userMessage == "Q")
                {
                    userHasQuit = true;
                }
                else if (userMessage == "m" || userMessage == "M")
                {
                    //Console.Clear();
                    Console.WriteLine("Here are all the messages you entered:");
                    Console.WriteLine(Messages()); //TODO use method call intead of local variable
                }
                else if (userMessage == "c" || userMessage == "C")
                {
                    //clear all messages
                    Messages("", true);
                    Console.Clear();
                }
                else
                {
                    Messages(userMessage);
                    //Console.Clear();
                }

            } while (userHasQuit == false);


            Console.Clear();
            Console.WriteLine("Here are all the messages you entered:");
            Console.WriteLine(Messages);


            //pause
            Console.Read();
        }

        static string Messages(string currentMessage = "", bool clear = false)
        {

            //trim whitespace
            currentMessage = currentMessage.Trim();
            //grab the contents of the global
            string messages = _messages;
            if (clear)
            {
                messages = "";
            }

            //TEST FOR "", SKIP IF ""

            // append the current message
            else if (messages.Length == 0 && currentMessage != "") //avoid initial blank line
            {
                messages += currentMessage;
            }
            else if (currentMessage != "")
            {
                // append the new current message
                messages += "\n" + currentMessage;
            }



            //store it back in the global
            _messages = messages;
            //return the accumulated messages
            return messages;

        }
    }
}

