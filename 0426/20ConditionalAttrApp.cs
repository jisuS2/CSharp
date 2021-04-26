#define CSHARP
using System;
using System.Diagnostics;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{
    class ConditionalAttr
    {
        [Conditional("CSHARP")]
        public static void CsharpMethod()
        {
            Console.WriteLine("In the CSharp Method ...");
        }
        [Conditional("JAVA")]
        public static void JavaMethod()
        {
            Console.WriteLine("In the Java Method ...");
        }
    }

    class ConditionalAttrApp
    {
        public static void Main()
        {
            ConditionalAttr.CsharpMethod();
            ConditionalAttr.JavaMethod();
        }
    }
}
