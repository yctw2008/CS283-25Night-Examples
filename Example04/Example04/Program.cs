using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example04
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 0.1f;
            float b = 0.2f;
            float c = 0.3f;
            float y = (1.0f / 2.0f) * (a + b) * 2.0f;
            Console.WriteLine(a + b == c);
            Console.WriteLine((a + b) * 1.0 / 2.0);
            Console.WriteLine((1.0 / 2.0) * (a + b));
            Console.WriteLine((1.0 / 2.0) * (a + b) * 2.0);
        }
    }
}
