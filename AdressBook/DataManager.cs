using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace AdressBook
{
    static class DataManager
    {
        public static string path { get; } = "AdressBook.txt";
        public static List<User> userList { get; set; } = new List<User>();

        public static List<User> SetupUsers()
        {
            List<string> fullRead;
            if(File.Exists(path))
            {
                using(StreamReader inStream = new StreamReader(path))
                {
                    fullRead = inStream.ReadToEnd().Split('\n').ToList();
                }
            }
            else
            {
                File.Create(path);
                fullRead = new List<string> { "" };
            }

            foreach(var entry in fullRead)
            {
                if(entry != "")
                {
                    var tryUser = new User(entry);
                    try
                    {
                        userList.Add(tryUser);
                    }
                    catch(Exception exc)
                    {
                        System.Windows.Forms.MessageBox.Show(exc.ToString());
                        throw;
                    }
                }
            }
            return userList;
        }

        public static bool SaveAllUsers()
        {
            using(StreamWriter outStream = new StreamWriter(path))
            {
                foreach(User item in userList)
                {
                    try
                    {
                        outStream.WriteLine(item.Serialize());
                    }
                    catch(Exception exc)
                    {
                        System.Windows.Forms.MessageBox.Show(exc.ToString());
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
