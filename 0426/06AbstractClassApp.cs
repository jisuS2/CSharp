using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{
    abstract class AbstractClass
    {
        public abstract void MethodA();
        public void MethodB()
        {
            Console.WriteLine("Implementation of MethodB()");
        }
    }
    class ImpClass : AbstractClass
    {
        override public void MethodA()
        {
            Console.WriteLine("Implementation of MethodA()");
        }
    }


    class AbstractClassApp
    {
        static void Main(string[] args)
        {
            ImpClass obj = new ImpClass();
            obj.MethodA();
            obj.MethodB();
        }
    }
}
