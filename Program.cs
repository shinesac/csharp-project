using System;
using System.Collections.Generic;
// using System.Linq;

namespace Flashcards
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(KeyValuePair<string, string> entry in QA.qa)
            {
                Console.WriteLine(entry.Key);
                Console.WriteLine("Press any key to see the answer");
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
                   
        }


            // Console.WriteLine("You got correct.Length right and wrong.Lenth wrong");

            // Console.WriteLine("Would you like to review the incorrect questions? y/n.");

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
