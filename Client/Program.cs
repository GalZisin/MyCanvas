﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _100219;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            do
            {
                Console.WriteLine("Enter button top left x point:");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter button top left y point:");
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter button bottom Right x point:");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter button bottom Right y point:");
                y2 = Convert.ToInt32(Console.ReadLine());

            }
            while (MyCanvas.CreatNewButton(x1, y1, x2, y2));
        }
    }
}
