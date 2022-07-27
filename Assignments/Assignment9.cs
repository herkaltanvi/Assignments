using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment9
    {
        int num, rem, total=0;
        public void Assignment()
        {
            Console.WriteLine("# Sum of all digits #");
            Console.Write("Enter the number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num!=0)
            {
                total = total + num % 10;
                num = num / 10;
            }
            Console.WriteLine(total);
        }
    }
}
