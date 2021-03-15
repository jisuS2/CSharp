using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyApp
{
    class PropertyClass
    {
        private int privateValue;
        public int PrivateValue
        {
            get { return privateValue; } //get
            set { privateValue = value; } //set
        }
        public void PrintValue()
        {
            Console.WriteLine("Hidden Value = " + privateValue);
        }
    }
    class propertyApp
    {
        public static void Main()
        {
            int n;
            PropertyClass obj = new PropertyClass();
            obj.PrivateValue = 100; //배정문의 왼쪽 set
            obj.PrintValue();
            n = obj.PrivateValue; //배정문의 오른쪽 get
            Console.WriteLine(" Value = " + n);
        }
    }
}