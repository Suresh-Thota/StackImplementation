using System;
using System.Collections.Generic;
using System.Text;

namespace StackProject
{
    class Demo
    {
        static void Main(String[] args)
        {
            int choice, x;
            Stack st = new Stack(10);
            while (true)
            {
                Console.WriteLine("1.push an element to the stack");
                Console.WriteLine("2.pop an element to the stack");
                Console.WriteLine("3.Display the top element");
                Console.WriteLine("4.Display all stack elements");
                Console.WriteLine("5.Display size of the stack");
                Console.WriteLine("6.Quit");
                Console.Write("enter your choise : ");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 6)
                    break;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("enter an element to push");
                        x = Convert.ToInt32(Console.ReadLine());
                        st.Push(x);
                        break;
                    case 2:
                        x = st.Pop();
                        Console.WriteLine("popped element is " + x);
                        break;
                    case 3:
                        Console.WriteLine("element at the top is " + st.Peek());
                        break;
                    case 4:
                        st.Dispaly();
                        break;
                    case 5:
                        Console.WriteLine("size of stack is" + st.Size());
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;
                }
                Console.WriteLine(" ");
            }
        }
    }
}
