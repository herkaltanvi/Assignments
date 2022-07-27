using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment8
    {
        string str, maxWord = "";
        int maxLength  = 0;
        public void Assignment()
        {
            Console.WriteLine("# Longest word in String#");
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            string[] strArray = str.Split(' ');
            for (int i = 0; i < strArray.Length; i++)
            {
                if (strArray[i].Length > maxLength)
                {
                    maxLength = strArray[i].Length;
                    maxWord = strArray[i];
                }
            }
            Console.WriteLine("Longest Word is {0}", maxWord);
            
        }
    }
}
