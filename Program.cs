﻿using System;

namespace WatermelonCodeforcesProjectOne
{
    class Program
    {
        static void Main()
        {
           
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 2 && n % 2 == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
