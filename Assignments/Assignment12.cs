using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment12
    {
        public void Assignment()
        {
            var num = "";
            int flag = 0;
            Console.WriteLine("# Pallindrome #");
            Console.Write("Enter the number : ");
            num = Console.ReadLine();
            for (int i = 0, j = num.Length - 1; i < (int)num.Length / 2; i++, j--){
                if (num[i] == num[j])
                {
                    continue;
                }
                else
                {
                    flag = 1;
                }
            }
            if(flag ==1)
            {
                Console.WriteLine($"The Number {num} is not a PALLINDROME.");
            }
            else
            {
                Console.WriteLine($"The Number {num} is a PALLINDROME.");
            }
        }
    }
}
