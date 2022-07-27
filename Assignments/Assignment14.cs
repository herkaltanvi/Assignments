using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment14
    {
        public void Assignment()
        {
            int num, str2num;
            string str, num2str; ;
            Console.WriteLine("# Conversion #");
            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            str2num = Convert.ToInt32(str);
            num2str = Convert.ToString(num);
            Console.WriteLine($"The data type of {num} after converting to string is {num2str.GetType()}");
            Console.WriteLine($"The data type of {str} after converting to integer is {str2num.GetType()}");

        }
    }
}
