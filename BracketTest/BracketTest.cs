using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class StackNode
    {
        public char data { get; set; }
        public StackNode link { get; set; }

    }

    public class LinkedStack
    {
        StackNode top;

        public bool isEmpty()
        {
            return (top == null);
        }

        public void push(Object item)
        {
            StackNode newNode = new StackNode();
            newNode.data = (char)item;

            newNode.link = top;
            top = newNode;
        }

        public char pop()
        {
            if (top == null)
            { Console.WriteLine("Deleting fail! Linked Stack is empty!!");
            }

            char item = top.data;
            top = top.link;
            return item;
        }

        public void delete()
        {
            if (top == null)
            { Console.WriteLine("Deleting fail! Linked Stack is empty!!"); }

            top = top.link;
        }

        public char peek()
        {
            if (top == null)
            { Console.WriteLine("Deleting fail! Linked Stack is empty!!"); }

            return top.data;

        }

        public void PrintStack()
        {
            if (top == null)
            { Console.WriteLine("Linked Stack is empty!!"); }

            StackNode temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.link;
            }
            Console.WriteLine();
        }
    }

    public class OptExp
    {
        private string exp;
        private int expSize;
        private char testCh, openPair;

        public bool testPair(string exp)
        {
            this.exp = exp;
            LinkedStack S = new LinkedStack();
            expSize = this.exp.Length;
            for (int i = 0; i < expSize; i++)
            {
                testCh = this.exp[i];
                switch (testCh)
                {
                    case '(':
                    case '{':
                    case '[':
                        S.push(testCh);
                        break;
                    case ')':
                    case '}':
                    case ']':
                        if (S.isEmpty())
                            return false;
                        else
                        {
                            openPair = S.pop();
                            if ((openPair == '(' && testCh != ')') || (openPair == '{' && testCh != '}')
                                    || (openPair == '[' && testCh != ']'))
                                return false;
                            else
                                break;
                        }
                }
            }
            if (S.isEmpty())
                return true;
            else
                return false;
        }
    }


    public class BracketTest
    {
        static void Main(string[] args)
        {
            OptExp opt = new OptExp();
            String exp = "(3*5)-6/2)";

            Console.WriteLine(exp);

            if (opt.testPair(exp))
                Console.WriteLine("괄호 맞음!!");

        else
                Console.WriteLine("괄호 틀림!!");

        }
    }
}
