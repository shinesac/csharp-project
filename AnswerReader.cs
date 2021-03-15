using System;
using System.Collections.Generic;

namespace Flashcards 
{
    public static class AnswerReader
    {
        public static bool Read(string input2, KeyValuePair <string, string> entry)
        {
             if (input2 == "y")
                            {
                                Correct.correct.Add(entry.Key, entry.Value);
                                Wrong.wrong.Remove(entry.Key);
                                return true;
                            }
                                return false;

        }
    }
}