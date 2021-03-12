using System;
using System.Collections.Generic;
using System.Linq;

namespace Flashcards
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (KeyValuePair<string, string> entry in QA.qa)
            {
                Console.WriteLine("\n" + entry.Key);
                Console.WriteLine("Press enter to see the answer");
                string input = Console.ReadLine();

                if (input == null)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(entry.Value + "\n");
                    Console.WriteLine("Did you get the answer right? y/n");
                    var input2 = Console.ReadLine().ToLower();

                    if (input2 == "y")
                    {
                        Correct.correct.Add(entry.Key, entry.Value);
                    }
                    else if (input2 == "n")
                    {
                        Wrong.wrong.Add(entry.Key, entry.Value);
                    }

                    else
                    {
                        continue;
                    }

                }

            }
            int CorrectCount = Correct.correct.Count;
            int WrongCount = Wrong.wrong.Count;
            Console.WriteLine("\n" + "Quiz Results: You got {0} correct and {1} wrong", CorrectCount, WrongCount );
            Console.WriteLine("\n" + "Would you like to review the incorrect questions? y/n.");
        }

        

                

       
      

        // input3 = Console.ReadLine().ToLower();

        //     if (!(input3 = "y"))
        //     {
        //         break;
        //     }
        //     else
        //     {
        //         public {} wrong = new QA {get, set};
        // }
        // }
    }
}
