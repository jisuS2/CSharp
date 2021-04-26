using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{
    class CLanguage
    {
        virtual public void Print()
        {
            Console.WriteLine("In the Clanguage class ...");
        }
    }
    class Java : CLanguage
    {
        override public void Print()
        {
            Console.WriteLine("In the Java class ...");
        }
    }

    class VirtualAndOverrideApp
    {
        static void Main(string[] args)
        {
            CLanguage c = new Java();
            c.Print();
        }
    }

}
