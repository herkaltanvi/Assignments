﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    class Assignment11
    {
        public void Assignment()
        {

            int[] res = new int[3];
            int[][] arr = new int[3][];

            arr[0] = new int[3] { 2, 3, 0 };
            arr[1] = new int[3] { 5, 8, 2 };
            arr[2] = new int[3] { 1, 4, 9 };



            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter element {j + 1} of Array {i + 1} : ");
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("# Middle Elements of an Array #");
            for (int i = 0; i < 3; i++)
            {
                res[i] = arr[i][1];
            }
            for (int i=0;i<3;i++)
            {
                Console.Write($"{res[i]}  ");
            }
            Console.WriteLine("");
        }
    }

}
