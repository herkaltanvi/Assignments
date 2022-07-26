using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment3
    {
        int num1, num2;

        public void Assignment()
        {
            Console.WriteLine("# Calculator #");
            Console.Write("Enter 1st number : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Addition : {0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("Subtraction : {0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("Multiplication : {0} * {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("Division : {0} / {1} = {2}", num1, num2, num1 / num2);
        }
    }
}
