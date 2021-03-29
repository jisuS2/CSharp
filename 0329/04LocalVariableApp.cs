using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 문장
{
    class LocalVariableApp
    {
        static int x;
        static void Main(string[] args)
        {
            int x = (LocalVariableApp.x = 2) * 2;
            Console.WriteLine("static x = " + LocalVariableApp.x);
            Console.WriteLine("local x = " + x);
        }
    }
}
