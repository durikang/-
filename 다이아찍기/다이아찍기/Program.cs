using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 다이아찍기
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++)
            {

                for (int j = 5; j - i > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int j = i; j < i + i + 1; j++)
                {
                    Console.Write("*");
                }

                    for (int j = i; j < i + i; j++)
                    {
                        Console.Write("*");
                    }
                    

                
                Console.WriteLine();
            }
            
            for(int i = 0; i < 5; i++)
            {

                for (int j = 0; j < i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 5; j - i > 0; j--)
                {
                    Console.Write("*");
                }
                for (int j = 4; j - i > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
