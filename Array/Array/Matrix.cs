using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Matrix
    {
        public void Arr()
        {
            Console.WriteLine("********Mang 2 chieu***********");
            Console.Write("Moi nhap so hang n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Moi nhap so cot m: ");
            int m = int.Parse(Console.ReadLine());
            int[,] arr = new int[n, m];
            Console.WriteLine("Moi nhap gia tri cho ma tran");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("phan tu thu tu a[{0}][{1}]", i, j);
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\n Ma tran da nhap la: ");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        
        }

    }
}
