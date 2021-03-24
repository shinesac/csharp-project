using System;
using System.Collections.Generic;
using System.Linq; 
using System.IO;


namespace Flashcards
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string currentDirectory = Directory.GetCurrentDirectory();
            DirectoryInfo directory = new DirectoryInfo(currentDirectory);
            var fileName = Path.Combine(directory.FullName, "data.csv");
            var fileContents = Data.ReadUserInfo(fileName);
           
            Console.WriteLine("Users: ");
            foreach (var user in fileContents)
            {
            Console.WriteLine(user.Username);
            }
            Console.WriteLine("\n" + "Please enter in your username:" );
            var userSelection = Console.ReadLine().ToLower();
            var isUser = 0;
            foreach(var user in fileContents)
            {
                if(userSelection == user.Username.ToLower())
                {
                    isUser ++;
                }
            }
            if (isUser < 1)
            {
                Console.WriteLine("Please enter a valid user!");
                System.Environment.Exit(1);
            }
                       // Console.WriteLine(userSelection);
            
                    // if (fileContents.ToString().ToLower().Contains(userSelection))
                    // {
                        
                    //     Console.WriteLine("User found");
                    // }
            // var activeUser = from user in fileContents
            //                 where user.Username == userSelection
            //                 select user;
                           // Console.WriteLine(activeUser);
                

                
                  
            
                    
                       
            foreach (KeyValuePair<string, string> entry in QA.qa)
                {
                    AskandShow.askandshow(entry);
                    var firstIsAnswerRight = Console.ReadLine().ToLower();
                    if (firstIsAnswerRight == "q")
                    {
                        break;
                    }
                    else
                    {
                        AnswerReader.SortResponses(firstIsAnswerRight, entry);  
                    }   
                }
                    
                int CorrectCount = Correct.correct.Count();
                int WrongCount = Wrong.wrong.Count();
                int QACount = QA.qa.Count();
                double scoreCount = (CorrectCount/QACount)*100;

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

                if (WrongCount == 0 & CorrectCount > 0)
                {
                
                    // File.WriteAllText(fileName, scoreCount.ToString());
                        
                    Console.WriteLine("\n" + "Congratulations, you got all answered questions correct!");          
                }
                
            }
        }
    }


