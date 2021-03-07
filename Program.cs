using System;
// using LINQ;

namespace Flashcards
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(KeyValuePair<string, string> entry in quiz)
            {
                Console.WriteLine(quiz.Key);
                Console.WriteLine("Press any key to see the answer");
                string input = Console.ReadLine();

            }
                
        //  (int index = 0; index < qa.Length; index++)
            
                // QA qa = qa[index];
               


                // if (input == null)
                // {
                //     continue;
                // }
                // else
                // {
                //     Console.WriteLine(quiz.Value);
                // }

                // Console.WriteLine("Did you get the answer right? y/n");

                // input2 = Console.ReadLine().ToLower();

                // if (input2 = "y")
                // {
                //     correct.Add(quiz.Key, quiz.Value);
                // }
                // elif(input2 = "n")
                // {
                //     wrong.Add(quiz.Key, quiz.Value);
                // }
                // else
                // {
                //     continue;
                // }
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
