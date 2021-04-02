using System;
using System.Collections.Generic;
using System.Linq; 
using System.IO;

namespace Flashcards
{
    public class Data
    {
        public static string ReadFile(string fileName)
        {
            using (var reader = new StreamReader(fileName))
            {
                return reader.ReadToEnd();
            }
        }
        public static List<User> ReadUserInfo(string fileName)
        {
            var userInfo = new List<User>();
            using(var reader = new StreamReader(fileName))
            {
                string line = "";
                reader.ReadLine();
                while((line = reader.ReadLine()) != null)
                {
                    var user = new User();
                    string[] values = line.Split(',');
                    user.Username = values[0];
                    user.Score = values[1];
                    userInfo.Add(user);
                }
            }
            return userInfo;       
        }       
    }
}