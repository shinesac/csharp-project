using System;
using LINQ;

namespace flashcards
{
    internal class NewBaseType
    {
        static void Main(string[] args)
        {
            for (int index = 0; index < qa.Length; index++)
            {
                QA qa = qa[index];
                Console.Write(qa.Key);
                Console.Write("Press any key to see the answer");
                string input = Console.ReadLine();


                if (input == null)
                {
                    continue;
                }
                else
                {
                    Console.Write(qa.Value);
                }

                Console.Write("Did you get the answer right? y/n");

                input2 = Console.ReadLine().ToLower();

                if (input2 = "y")
                {
                    correct.Add(qa);
                }
                elif(input2 = "n")
                {
                    wrong.Add(qa);
                }
                else
                {
                    continue;
                }
            }


            Console.Write("You got correct.Length right and wrong.Lenth wrong");

            Console.WriteLine("Would you like to review the incorrect questions? y/n.");

        input3 = Console.ReadLine().ToLower();

            if (!(input3 = "y"))
            {
                break;
            }
            else
            {
                public {} wrong = new QA {get, set};
            }
        }
    }

