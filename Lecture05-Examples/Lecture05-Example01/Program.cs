using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture05_Example01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入狀態代碼，成功(1)，失敗(404)，斷線(405)，已連線(406)");
            Status Status = (Status)int.Parse(Console.ReadLine());
            Status status = (Status) int.Parse 
                (Console.ReadLine());

            switch (status)
            {
                case Status.Success:
                    Console.WriteLine("成功");
                    break;
                case Status.Error:
                    Console.WriteLine("失敗");
                    break;
                case Status.Disconnect:
                    Console.WriteLine("斷線");
                    break;
                case Status.Connected:
                    Console.WriteLine("已連線");
                    break;
                default:
                    Console.WriteLine("您輸入的是{0},編號不正確",
                        status);
                    break;


            }         
        }
    }
}
