using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculator iphone = new Calculator();
            int result = iphone.Add(2, 3);
            Console.WriteLine(result);
            Console.WriteLine(iphone.Add(2, 3));
        }
    }
}
