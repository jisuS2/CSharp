using System;
using Shape;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{
    class NamespaceApp
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.width = 10;
            rect.height = 20;
            Console.WriteLine("rect : " + rect);
        }
    }

}
