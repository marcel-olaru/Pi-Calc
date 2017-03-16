using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi
{
    class Program
    {
        static void Main()
        {
            var random = new Random();
            var total = 1000000000;
            int count = 0;
            var time1 = DateTime.Now;
            for (int i = 0; i < total; i++)
            {
                var a = random.Next() & 0x7FFFFFFF;
                var b = random.Next() & 0x7FFFFFFF;
                if (GCD(a, b) == 1) count++;
                Console.WriteLine($"hello from for {count}");
                

            }
            double proportion = (double)count / (double)total;
            var piEstimate = Math.Sqrt(6 / proportion);
            var time2 = DateTime.Now;
            var timeElapsed = (time2 - time1).ToString();
            //String.Format("{0:mm:ss}", timeElapsed);

            Console.WriteLine($"Time elapsed to calculate : {timeElapsed}");

            Console.WriteLine($"Pi estimated for {total} numbers is  {piEstimate}");

            Console.ReadLine();
        }

       public static int GCD(int x , int y)
        {
            return y == 0 ? x : GCD(y, x % y);
        }

        static int GCDr(int[] numbers)
        {
            return numbers.Aggregate(GCD);
        }



    }


    



}

