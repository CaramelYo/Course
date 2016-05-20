using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int price = 560, number = 5;
            string name = "Visual C# 2012";

            Console.WriteLine();
            Console.WriteLine("電腦書廣場");
            Console.WriteLine("1. 書名：" + name);
            Console.WriteLine("1-1. 書名：{0}", name);
            Console.WriteLine("2. 售價：" + price);
            Console.WriteLine("2-1. 售價：{0}", price);
            Console.WriteLine("3. 數量：" + number);
            Console.WriteLine("3-1. 數量：{0}", number);
            Console.WriteLine("4. 金額：" + price * number);
            Console.WriteLine("4-1. 金額：{0}", price * number);
            Console.WriteLine("5. 打八折後 ：" + price * number * 0.8);
            Console.WriteLine("5-1. 打八折後 ：{0}", price * number * 0.8);

            Console.Read();
            */
            int i, j, number, count, temp ;

            Console.WriteLine("請選擇 1>正方形 2>三角形 ：");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("請輸入需要繪製的大小：");
                    number = Int32.Parse(Console.ReadLine());
                    count = 0;

                    for(i=0; i<number; ++i)
                    {
                        for (j = 0; j < number; ++j)
                        {
                            Console.Write("*");
                            ++count;
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("共使用 {0} 個 \' * \'", count);
                    Console.Read();
                    break;
                case "2":
                    Console.WriteLine("請輸入需要繪製的大小：");
                    number = Int32.Parse(Console.ReadLine());
                    if(number >9)
                    {
                        Console.WriteLine("數字要介於1~9!!");
                        Console.WriteLine("請重新執行!");
                        Console.Write("請按任意鍵繼續．．．");
                        Console.Read();
                        return;
                    }
                    count = 0;

                    for (i = 1; i <= number; ++i)
                    {
                        for (j = 0; j < number - i; ++j)
                        {
                            Console.Write(" ");
                        }
                        for(j = 0; j < i*2 -1; ++j)
                        {
                            Console.Write(i);
                            ++count;
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("共使用 {0} 組數字 和 {1} 個數字", number, count);
                    Console.Read();

                    break;
                default:
                    Console.WriteLine("請重新執行!");
                    Console.Write("請按任意鍵繼續．．．");
                    Console.Read();
                    break;
            }
            return;
        }
    }
}
