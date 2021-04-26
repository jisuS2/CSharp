using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DerivedClass_Exception
{
    class IndexOutOfRangeApp
    {
        public static void Main()
        {
            int[] vector = { 1, 2, 3 };
            vector[4] = 4;
        }
    }
}