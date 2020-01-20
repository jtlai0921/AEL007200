using System;
using System.Collections.Generic;
using System.Text;

namespace ch1_5A
{
    class Program
    {
        static void Main(string[] args)
        {   //宣告
            string MyName;
            int MyAge;
            //輸入
            Console.Write("請輸入名字：");
            MyName = Console.ReadLine();
            Console.Write("請輸入年齡：");
            MyAge = int.Parse(Console.ReadLine());
            //輸出
            Console.WriteLine("{0} 您好! , 您是 {1} 歲 ", MyName, MyAge);
            Console.Read();
        }
    }
}
