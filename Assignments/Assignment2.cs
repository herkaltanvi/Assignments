using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment2
    {
        int num1, num2;
        public void Assignment()
        {
            Console.WriteLine("# Swap two numbers #");
            Console.Write("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 1st number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After Swpping the Numbers\n1st Number : {0}\n2nd Number : {1}", num1, num2);

        }
    }
}
