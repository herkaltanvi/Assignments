using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment6
    {
        string str;
        char temp;

        public void Assignment()
        {
            Console.WriteLine("# Interchange First and Last Letter #");
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            StringBuilder newStr = new StringBuilder(str);
            temp = str[0];
            newStr[0] = str[str.Length - 1];
            newStr[newStr.Length - 1] = temp;
            Console.WriteLine(newStr.ToString());
        }
    }
}
