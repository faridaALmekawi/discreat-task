using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perfect_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter first number");
            int x = int .Parse (Console.ReadLine());
            Console.WriteLine("please enter second number");
            int y = int.Parse  (Console.ReadLine());
            int per;
            for (int i = x; i <=y; i++)
            {
                per = 0;
                for (int j = 1; j <=i/2 ; j++)
                {
                    if(i % j == 0)
                    {
                        per += j;
                    }
                }


                if (per == i)
                {
                    Console.WriteLine(per);
                }
            }

        }
    }
}
