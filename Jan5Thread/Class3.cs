﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Jan5Thread
{
    internal class Class3
    {
        static void Fun1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Function 1 Called {0}", i);
                Thread.Sleep(1000);// 1 second
            }
        }
        static void Main(string[] args)
        {//parent thread 
            Console.WriteLine("parent thread starts");
            Thread childTh1 = new Thread(Fun1);
            childTh1.Start();//FGT
            Console.WriteLine("Parent thread stopped");
        }
    }
}
