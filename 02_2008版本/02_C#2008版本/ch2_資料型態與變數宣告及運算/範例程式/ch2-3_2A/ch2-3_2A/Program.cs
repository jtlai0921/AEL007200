﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ch2_3_2A
{
    class Program
    {
        static void Main(string[] args)
        {   //宣告
            int i = 60, j = 61;
            float c;
            //處理
            c = (i + j) / 2;  //沒有強制轉換
            //輸出
            Console.WriteLine("平均成績為：{0}", c);
            Console.ReadLine();
        }
    }
}
