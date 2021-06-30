using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MetodosDeOrdenacion
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] A = { 1, 7, 4, 6, 9 };
            Console.WriteLine(A);
            int l = A.Length;
            for (int i = 0; i < l-1 ; i++)
            {
                for (int j = 0; j < l-i-1; j++)
                {
                    if (A[j] > A[j + 1])
                    {
                        int m = A[j];
                        A[j] = A[j + 1];
                        //  A[j + 1] = A[j];
                        A[j + 1] = m;
                    }
                }
            }
            Console.WriteLine(A);
            Console.ReadLine();
        
        } 
    }
}
