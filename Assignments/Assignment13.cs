using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment13
    {
        public void Assignment()
        {

            char val;
            Console.WriteLine("# ASCII Value #");
            Console.Write("Enter a character : ");
            val = Convert.ToChar(Console.ReadLine());
            Console.WriteLine($"The ASCII value of {val} is {Convert.ToInt16(val)}");
        }
    }
}
