using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入盤數：");
            int i = int.Parse(Console.ReadLine());
            Hanoi(i, 'A', 'B', 'C');
            //Console.WriteLine("Over");
            Console.Write(".............");
            Console.Read();
            return;
        }
        
        static void Hanoi(int num, char a, char b, char c)
        {
            if(num > 0)
            {
                Hanoi(num - 1, a, c, b);
                //Console.WriteLine("Move No.{0} disk from {1} to {2}", num, a, c);
                Console.WriteLine("Move sheet from {0} to {1}", a, c);
                Hanoi(num - 1, b, a, c);
            }
            return;
        }
    }
}
