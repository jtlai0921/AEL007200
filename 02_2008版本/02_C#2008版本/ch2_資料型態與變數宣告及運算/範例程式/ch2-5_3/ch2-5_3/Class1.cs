using System;
using System.Collections.Generic;
using System.Text;

namespace ch2_5_3
{
     public class Class1
    { //������ܼ�
        static int A, B, C;
        static int Sum;
        static void Main(string[] args)
        {  //������ܼ�
            A = 10;
            B = 20;
            C = 30;
            ProcedureA();   //�I�sA�{�Ǥ��Ƶ{��
            ProcedureB();   //�I�sB�{�Ǥ��Ƶ{��
            Console.ReadLine();
        }
         static void ProcedureA()  //A�{�Ǥ��Ƶ{��
         {  //������ܼ�
            int A, B, C;
            A = 1;
            B = 2;
            C = 3;
            Sum = A + B + C;
            Console.WriteLine("�{��A=" + Sum.ToString());
        }
         static void ProcedureB()  //B�{�Ǥ��Ƶ{��
         { //������ܼ�
            Sum = A + B + C;
            Console.WriteLine("�{��A=" + Sum.ToString());
        }
    }
}
