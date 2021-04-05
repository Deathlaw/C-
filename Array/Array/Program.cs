using System;

namespace Array
{
    class Program
    {
        public void GetInfo()
        {
            // Nhap thong tin tinh toan!!! 
            Console.WriteLine("******** Chuong trinh tim phan tu MAX *******");
            Console.Write("Moi nhap so phan tu can tinh: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            // Ham tinh toan!!!
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap so thu {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        
        public void MaxArr()
        {
            // Nhap thong tin tinh toan!!! 
            Console.WriteLine("******** Chuong trinh tim phan tu MAX *******");
            Console.Write("Moi nhap so phan tu can tinh: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            // Ham tinh toan!!!
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap so thu {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0];

            Console.WriteLine("\nGia tri vua nhap la:\n");
            for (int i = 1; i< n; i++)
            {
                Console.Write("{0}" + " ", arr[i]);
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            Console.Write("Gia tri lon nhat la: {0}", max);
         
        }

        public void Sapxep()
        {
            Console.Write("Moi nhap size cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int [] arr = new int[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Moi nhap so thu {0}: ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                    
                }
            }
            Console.WriteLine("Mang sau khi da sap xep theo thu tu tang dan la: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
        public void Show()
        {
            Program arr = new Program();
            arr.Sapxep();
            
        }

        static void Main(string[] args)
        {
            Program arr = new Program();
            Matrix matrix = new Matrix();
            //matrix.Arr();
            List list = new List();
            list.CreateInitialize();

        }
    }
}
