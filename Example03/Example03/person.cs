using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    public class person
    {
        public string Name;
        public position Pos;
        public double Angle;
        public void MoveForward (double d)
        {
            Pos.X = Pos.X + d * Math.Cos(Angle*Math.PI/180.0);
            Pos.Y = Pos.Y + d * Math.Cos(Angle * Math.PI / 180.0);
            WriteLine();

        }
        public void TurnRight(double angle)
        {
            Angle = (Angle + angle) % 360.0;
            WriteLine();
        }

        public void WriteLine()
        {
            Console.WriteLine("{0}的位置在({1},{2}),方位角:{3}度",Name,Pos.X, Pos.Y, Angle);
            
        }
        public void DrawSquare(double width)
        {
          
            Elsa.MoveForward(100);
            Elsa.TurnRight(45);
            Elsa.MoveForward(100);
            Elsa.TurnRight(45);
            Elsa.MoveForward(100);
            Elsa.TurnRight(45);
            Elsa.MoveForward(100);
            Elsa.TurnRight(45);
        }
    }
}
