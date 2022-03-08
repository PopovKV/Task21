using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task21
{
    class Program
    {
        const int n = 10;
        public static int[,] Field = new int[n, n];
        

        static void Main(string[] args)
        {
            
            ThreadStart threadstart = new ThreadStart(Farm1);
            Thread myThread = new Thread(threadstart);
            myThread.Start();

            Farm2();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", Field[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        public static void Farm1()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Field[i, j] == 0)
                    {
                        Field[i, j] = 1;
                    }
                    

                }
                Thread.Sleep(i);
            }
        }

        public static void Farm2()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Field[n - j - 1, n - i - 1] == 0)
                    {
                        Field[n - j - 1, n - i - 1] = 2;
                    }
                    

                }
                Thread.Sleep(i);
            }
        }
    }
}
