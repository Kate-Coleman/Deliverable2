using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string mixedInput;
            string lowerInput;
            do
            {

                Console.WriteLine("Say something to the bot! Use the following commands: Hello, bye, sup, or hello there.");
                mixedInput = Console.ReadLine();
                lowerInput = mixedInput.ToLower();

                if (lowerInput == "hello")
                {
                    Console.WriteLine("Hi good to see you");
                }

                else if (lowerInput == "sup")
                {
                    Console.WriteLine("I am good");
                }
                else if (lowerInput == "hello there")
                {
                    Console.WriteLine("General Kenobi");
                }
                else if (lowerInput == "bye")
                {
                    Console.WriteLine("Good Bye!");
                }
            }

            while (lowerInput != "bye");
            /*
                    switch (lowerInput)
                    {
                        case "hello":
                            Console.WriteLine("Hi good to see you");
                            break;

                        case "sup":
                            Console.WriteLine("I am good");
                            break;

                        case "hello there":
                            Console.WriteLine("General Kenobi");
                            break;

                        case "bye":
                            Console.WriteLine("Good Bye!");
                            break;


                    */
        }
    }
}
            



