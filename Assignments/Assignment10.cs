using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment10
    {
        public void Assignment()
        {

            int temp;
            int[] arr = new int[3];
            Console.WriteLine("# Rotate Array #");
            Console.Write("Enter 1st number : ");
            arr[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 2nd number : ");
            arr[1] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter 3rd number : ");
            arr[2] = Convert.ToInt32(Console.ReadLine());
            temp = arr[0];
            for(int i = 1; i<3; i++)
            {
                arr[i - 1] = arr[i];
            }
            arr[2] = temp;
            Console.WriteLine("Rotated Array");

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"{arr[i]}  ");
            }
        }
    }

}
