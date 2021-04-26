using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{

    class BaseClass
    {
        public virtual void Output()
        {
            Console.WriteLine("In the Base class ...");
        }
    }
    class DerivedClass : BaseClass
    {
        public override void Output()
        {
            Console.WriteLine("In the Derived class ...");
        }
    }

    class PolymorphismApp
    {
        static void Print(BaseClass obj)
        {
            obj.Output();
        }
        static void Main(string[] args)
        {
            BaseClass obj1 = new BaseClass();
            DerivedClass obj2 = new DerivedClass();
            Print(obj1);
            Print(obj2);
        }
    }
}
