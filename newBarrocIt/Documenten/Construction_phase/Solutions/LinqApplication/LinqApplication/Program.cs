using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            SelectFromArray();
            Console.ReadLine();
        }

        public static void SelectFromArray()
        {
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            foreach(int num in numQuery)
            {
                Console.Write("{0}", num);
            }

            Console.WriteLine("\n");
        }

        public static void SortDescending()
        {

        }
    }
}
