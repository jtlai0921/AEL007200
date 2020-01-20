using System;
using System.Collections.Generic;
using System.Text;

namespace ch2_5_3
{
     public class Class1
    { //办┦跑计
        static int A, B, C;
        static int Sum;
        static void Main(string[] args)
        {  //办┦跑计
            A = 10;
            B = 20;
            C = 30;
            ProcedureA();   //㊣A祘ぇ捌祘Α
            ProcedureB();   //㊣B祘ぇ捌祘Α
            Console.ReadLine();
        }
         static void ProcedureA()  //A祘ぇ捌祘Α
         {  //办┦跑计
            int A, B, C;
            A = 1;
            B = 2;
            C = 3;
            Sum = A + B + C;
            Console.WriteLine("祘A=" + Sum.ToString());
        }
         static void ProcedureB()  //B祘ぇ捌祘Α
         { //办┦跑计
            Sum = A + B + C;
            Console.WriteLine("祘A=" + Sum.ToString());
        }
    }
}
