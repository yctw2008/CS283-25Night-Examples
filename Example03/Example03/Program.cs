using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class Program
    {
        static void Main(string[] args)
        {       
            person Elsa = new person()
            {
                Name = "Elsa",
                Pos = new position()
                {
                  X = 0,
                  Y = 0
                },
                Angle = 0
            };

           for(var count = 0; count<3; count++)
            {
                Elsa.DrawSquare(100);
                Elsa.TurnRight(120);
            };
        }
    }
}
