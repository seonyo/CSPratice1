﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSPratice1
{
    internal class Parent
    {
        public Parent() 
        {
            Console.WriteLine("부모 생성자 호출");
        }

       public Parent(string input) 
        {
            Console.WriteLine(input);
        }
    }
}
