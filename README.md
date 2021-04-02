# csharp-project

Overview

This project is my capstone project for the C# Code Louisville class.  The program is a questionairre program, which I call flashcards. 
The program asksfor your name and checks to see if you are a valid user.  If you are a valid user, then you are able to continue the program.
If not, it will abort. If you are a valid user, it will then ask you a series of questions, which you answer in your head. It will then display
the correct answer when you press enter. You enter in "y"or "n" depending on if you got the answer correct or wrong. 
It will go through the series of questions (6 questions) until you exit by entering "q" or completed all of the questions. 
It will then tell you how many questions you answered right and wrong depending on your response. If you got any questions wrong, it will ask you
if you want to review those questions. If you select "y" then it will re-quiz you on those questions you got incorrect.
 If you say no, it will exit. You can continue the program until you have no more wrong answers. 

How to run (for looking at features)

1. Run the program
2. When prompted to enter your user name, enter any name that is not Shinesa, Dan, Carla or guest to see the program reject an invalid
user. Then re-run the program and enter in "guest" to continue. 
3. Go through the questionairre. You can go through it the first time by answering some of the questions wrong and some right by entering "y" for some questions
and "n" for the others. See how many you got wrong and right.
4. Enter in "y" to review your incorrect questions. Enter in "y" for some of the questions and "n" for others to see it continue to run until you get all right. 
5. See how many you got wrong and right. Enter in "y" to review your incorrect questions. 
6. Enter in "y" for all of the questions, so you can finish the program by getting all the questions right.
7. Re-run the program and enter in "guest" again for your user name. This time answer everything correctly by entering "y" for all questions. You will have answered all correctly and
it will not prompt you to review.
8. Re-run the program. Enter in "Carla" for the user name to see the program accept this name as well since it is a valid user (a name listed on the csv file). Then press "q" to see the 
program exit. 

Features

1. Master loop is used to go through the questions (while loop) and you can exit by entering "q": Implement a “master loop” console application where the user can repeatedly enter commands/perform actions, 
including choosing to exit the program

2. File reads from a csv file to check to see if you enter in a valid user:  Read data from an external file, such as text, JSON, CSV, etc and use that data in your application.

3. Dictionary is used for the questions and answers: Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program

4. The number of questions you answer correctly and incorrectly is counted and displayed to the user: Analyze text and display information about it (ex: how many words in a paragraph)

Functions (part of requirements)

The functions are:

1. askandshow (established in class AskandShow)
2. SortResponses (Established in class AnswerReader)
3. Read (called in line 76 of Program and established in class AnswerReader. Returns true/false value. 




