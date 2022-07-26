using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment5
    {
        int num;
        public void Assignment()
        {
            Console.WriteLine("# Display Pattern #");
            Console.Write("Enter number : ");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.Write("{0}", num);
            }
            Console.WriteLine();
        }
    }
}
