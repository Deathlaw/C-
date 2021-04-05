using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class List
    {
        public void Print(ArrayList list, string label)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{label}: ");
            Console.ResetColor();

            if (list.Count == 0)
            {
                Console.Write("EMPTY!");
            }

            foreach (object item in list)
            {
                Console.Write($"{item}\t");
            }

            /*for (int i = 0; i< list.Count; i++)
            {
                Console.Write($"{list[i]}\t");
            }*/

            Console.ReadKey();
        }

        public void CreateInitialize()
        {
            Console.WriteLine("#Khoi tao ArrayList");

            Console.WriteLine("moi nhap kich co arrayList: ");
            int n = int.Parse(Console.ReadLine());
            var list1 = new ArrayList(new int [n]);
            Console.WriteLine("Moi nhap so phan tu trong Array List: ");
            /*foreach (int ob in list1)
            {
                Console.Write("Phan tu thu: {0}" +ob);
                list1[ob] = int.Parse(Console.ReadLine());
            }*/

            for (int i = 0; i< list1.Count; i++)
            {
                Console.Write("Moi nhap so thu {0}: ", i);
                list1[i] = int.Parse(Console.ReadLine());
            }
            

            
            //var list2 = new ArrayList(new object[] {"Alo",1, 2, 3, true});
            //var list3 = new ArrayList(5);

            Print(list1, "LIST 1");
            //Print(list2, "LIST 2");
            //Print(list3, "LIST 3");

            Console.WriteLine("#######");
        }
    }
}
