using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sorting;

namespace Launcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ISort insertSort = new InsertSort();
            var list = insertSort.Sort(new int[] {5, 2, 4, 6, 1, 3});
            foreach (var number in list)
            {
                Console.Write(number + " ");
            }
        }
    }
}
