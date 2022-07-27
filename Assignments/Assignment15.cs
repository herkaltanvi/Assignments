using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment15
    {
        public void Assignment()
        {

            string s, newStr = "";

            Console.WriteLine("# Remove non-letter characters #");
            Console.Write("Enter the string : ");
            s = Console.ReadLine();
            for(int i = 0; i<s.Length;i++)
            {
                int a = (int)s[i];
                if (a>64 &&a<91 || a>96 &&a<123 || a==32)
                {
                    newStr += (char)a;
                }
            }
            Console.WriteLine($"New string : {newStr}");
        }
    }
}
