﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Excercise4
{
    class inputData
    {
        public int info;
        public inputData next;
        public inputData(int i, inputData n)
        {
            info = info;
            next = next;
        }
    }

    class Stack
    {
        inputData top;

        public Stack()
        {
            top = null;
        }

        bool empty()
        {
            if (top == null)
                return true;
            else
                return false;
        }
        public void push(int element)
        {
            inputData fresh;
            fresh = new inputData(element, null);

            fresh.next = top;
            top = fresh;
            Console.WriteLine("\n" + element + "pushed");

        }

        public void pop()
        {
            Console.WriteLine("\n the poped element is: " + top.info);
            top = top.next;
        }

        public void display()
        {
            inputData tmp;
            if (empty())
                Console.WriteLine("\n Stack empty");
            
        }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
