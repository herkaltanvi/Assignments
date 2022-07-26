using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment4
    {
        int num;
        public void Assignment()
        {
            Console.WriteLine("# Number table #");
            Console.Write("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
            }
        }
    }
}
