using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            ArrayList arrayList = new ArrayList();

            bool IsPirme=false;

            arrayList.Add(2);
            arrayList.Add(3);
            arrayList.Add(5);

            for(int i = 2; i <= 100; i++)
            {
                if (i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                {
                    arrayList.Add(i);
                }

            }

            for(int i = 0; i < arrayList.Count; i++)
            {
                if (arrayList[i].Equals(n))
                {
                    IsPirme = true;
                    break;
                }

            }

            if (IsPirme)
            {
                Console.WriteLine(IsPirme);
            }
            else
            {
                Console.WriteLine(IsPirme);

            }



        }
    }
}
