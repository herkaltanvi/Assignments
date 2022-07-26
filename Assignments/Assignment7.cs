using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment7
    {
        int num1, num2;
        public void Assignment()
        {
            Console.WriteLine("# One Positive and One Negative Number #");
            Console.Write("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > 0 && num2<0 || num1 < 0 && num2 > 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");

            }
        }
    }
}
