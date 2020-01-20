using System;using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,j;
            int[,] A = new int[3,3];
            A[0, 0] = 1; A[0, 1] = 2; A[0, 2] = 3;
            A[1, 0] = 4; A[1, 1] = 5; A[1, 2] = 6;
            A[2, 0] = 7; A[2, 1] = 8; A[2, 2] = 9;

            int[,] B = new int[,] {{1,2,3},{4,5,6},{7,8,9}};
            for (i = 0; i <= 2; i++)
                for (j = 0; j <= 2;j++ )
                {
                        Console.WriteLine(A[i,j]);
                   // Console.WriteLine(B[i,j]);
                }
            Console.ReadLine();
        }
    }
}
