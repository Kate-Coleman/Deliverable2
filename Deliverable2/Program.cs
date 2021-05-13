using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            string lowerInput;
            var hello = true;
            var sup = true;
            var hellothere = true;

            do
            {
                Console.WriteLine("Say something to the bot! Use the following commands: Hello, bye, sup, or hello there.\n");
                lowerInput = Console.ReadLine().ToLower();


                switch (lowerInput)
                {
                    case "hello":

                        if (hello)
                        {
                            Console.WriteLine("Hi good to see you\n");
                            hello = false;
                        }
                        else
                        {
                            Console.WriteLine("Say something else please.\n");
                        }

                        break;

                    case "sup":

                        if (sup)
                        { 
                            Console.WriteLine("I am good\n");
                            sup = false;
                        }
                        else
                        {
                            Console.WriteLine("Say something else please.\n");
                        }

                        break;

                    case "hello there":

                        if (hellothere)
                        {
                            Console.WriteLine("General Kenobi\n");
                            sup = false;
                        }
                        else
                        {
                            Console.WriteLine("Say something else please.\n");
                        }

                        break;

                    case "bye":

                        Console.WriteLine("Good Bye!\n");

                        break;

                    default:
                        Console.WriteLine("Invalid greeting. Please try again!\n");
                        break;

                }
            } while (lowerInput != "bye");


        }
    }
}


