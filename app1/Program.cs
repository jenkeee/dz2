using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int num = 0;

            do
            {
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 == 1)
                    sum += num;

            } while (num != 0);

            Console.WriteLine("Sum: " + sum);

            Console.ReadKey();
        }


    }
}