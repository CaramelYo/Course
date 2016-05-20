using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cho, size, count=0, count2=0, count3=0;

            Console.WriteLine("請選擇 1) 正方形 2)三角形 :");
            cho = int.Parse(Console.ReadLine());
            if(cho>2 || cho < 1)
            {
                Console.WriteLine("請重新執行 !");
                return;
            }
            Console.WriteLine("請輸入需要繪製的大小: ");
            size = int.Parse(Console.ReadLine());

            if (cho == 1)
            {
                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        Console.Write("*");
                        count = count + 1;
                    }
                    Console.WriteLine();
                }
                Console.Write("共使用 {0} 個 ' * ' ", count);
            }
            else if (cho == 2)
            {
                for (int i = 1; i <= size; i++)
                {
                    for (int j = 0; j < size - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write(i);
                        count3++;
                    }
                    Console.WriteLine();
                    count2++;
                }
                Console.Write("共使用 {0} 組數字 和 {1} 個數字", count2, count3);
                Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
