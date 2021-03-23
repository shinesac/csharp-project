using System;
using System.Collections.Generic;

namespace Flashcards
{
    public static class AskandShow
    {
        public static void askandshow(KeyValuePair <string, string> entry)
        {
             Console.WriteLine("\n" + entry.Key);
                            Console.WriteLine("Press enter to see the answer");
                            string seeAnswer = Console.ReadLine();
                            
                            Console.WriteLine(entry.Value + "\n");
                            Console.WriteLine("Did you get the answer right? y/n OR enter 'Q' to quit");
        }
    }

}