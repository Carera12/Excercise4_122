using System;
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
            else
            {
                for (tmp = top; tmp != null; tmp = tmp.next)
                {
                    Console.WriteLine(tmp.info);
                }

            }
        }

        static void Main(string[] args)
        {
            Stack s = new Stack();
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n*****Asrul Menu*****");
                Console.WriteLine("1. pop");
                Console.WriteLine("2. push");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.WriteLine("\nEnter your Choice: ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "36" : input);
                switch (ch)
                {
                    case '1':
                        Console.Write("\n Enter a number: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        s.push(num);
                        break;
                    case '2':
                        if (s.empty())
                        {
                            Console.WriteLine("\n Stack empty");
                            break;
                        }
                        s.pop();
                        break;
                    case '3':
                        s.display();
                        break;
                    case '4':
                        return;
                    default:
                        Console.WriteLine("\n Invalid Choice");
                        break;
                }
            }
        }
    }
}
