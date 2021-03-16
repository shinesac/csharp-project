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
                AskandShow.askandshow(entry);
                var firstIsAnswerRight = Console.ReadLine().ToLower();
                AnswerReader.SortList(firstIsAnswerRight, entry);     
            }
           
            int CorrectCount = Correct.correct.Count();
            int WrongCount = Wrong.wrong.Count();

            while (WrongCount != 0)
            {   
                Console.WriteLine("\n" + "Quiz Results: You got {0} correct and {1} wrong!", CorrectCount, WrongCount );
                Console.WriteLine("\n" + "Would you like to review the incorrect questions? y/n.");

                var reviewQuestions = Console.ReadLine().ToLower();
           
                if (reviewQuestions == "y")
                {
                    Correct.correct.Clear();
                   
                    foreach (KeyValuePair<string, string> entry in Wrong.wrong)
                    {
                        AskandShow.askandshow(entry);
                        var secondIsAnswerRight = Console.ReadLine().ToLower();

                        if (AnswerReader.Read(secondIsAnswerRight, entry) == false)
                        {
                            continue;
                        }
                    }

                    CorrectCount = Correct.correct.Count();
                    WrongCount = Wrong.wrong.Count();
                }
                else if (reviewQuestions == "n")
                {
                    break;
                }
            }

            if (WrongCount == 0)
            {
                Console.WriteLine("\n" + "Congratulations, you got all answers correct!");
            }
        }
    }
}