using System;
using System.Collections.Generic;

namespace Flashcards 
{
    public static class AnswerReader
    {
        public static bool Read(string secondIsAnswerRight, KeyValuePair <string, string> entry)
        {
             if (secondIsAnswerRight == "y")
                            {
                                Correct.correct.Add(entry.Key, entry.Value);
                                Wrong.wrong.Remove(entry.Key);
                                return true;
                            }
                                return false;

        }

        public static void SortResponses(string firstIsAnswerRight, KeyValuePair <string, string> entry)
        {
                 if (firstIsAnswerRight == "y")
                {
                    Correct.correct.Add(entry.Key, entry.Value);
                }
                else if (firstIsAnswerRight == "n")
                {
                    Wrong.wrong.Add(entry.Key, entry.Value);
                } 
               
        }
    }
}