using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            MethodSumAsync(n);
   
          //для проверки:
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Экспериментыыыыыы");
            }
     
            Console.ReadKey();
        }
        static void MethodFuct(int n)
        {
            int s = 1;
            for (int i = 1; i < n+1; i++)
            {
                s*=i;
                Thread.Sleep(50);
            }
            Console.WriteLine(s);
        }
        static async void MethodSumAsync(int n)
        {
            await Task.Run(() => MethodFuct(n));
        }
    }

}
