using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank.UnitTesting
{
    public static class Strings
    {
        public static string LoadTextFile(string file)
        {
            if (file.Length < 10)   
            {
                throw new ArgumentException("the file is too short", "file");
                //throw new System.IO.FileNotFoundException();
            }
            return "The File is Correctly Loaded";
        }

    }
}
