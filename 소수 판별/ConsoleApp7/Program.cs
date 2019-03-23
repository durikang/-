using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool []isPrime = new bool[n+1];
            if (n >= 2)
            {
                for (int i = 2; i <=n; i++)
                {
                    if (isPrime[i] == false)
                    {
                        for(int j = i * 2; j <= n; j += i)
                        {
                            isPrime[j] = true;
                        }
                    }
                }
                
                if (!isPrime[n])
                    Console.WriteLine($"{n}은 소수입니다.");
                else
                    Console.WriteLine($"{n}은 소수가 아닙니다.");

            }
            else
            {
                Console.WriteLine($"{n}은 소수가 아닙니다.");

            }



        }
    }
}
