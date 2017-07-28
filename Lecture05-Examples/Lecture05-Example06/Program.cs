using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05_Example06
{
    class Program
    {
        static void Main(string[] args)
        {
            int next = 0;
            int total = 0;
            while (total < 1000)
            {
                total += (next++);
            }

            Console.WriteLine("next =" + next);
            Console.WriteLine("total =" + total)
            
        }
    }
}
