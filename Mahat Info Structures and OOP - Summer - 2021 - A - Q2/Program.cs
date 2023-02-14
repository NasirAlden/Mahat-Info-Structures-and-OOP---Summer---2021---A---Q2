using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mahat_Info_Structures_and_OOP___Summer___2021___A___Q2
{
    internal class Program
    {
        public static List<int> FilterDuplicates(List<int> numbers)
        {
            List<int> filteredList = new List<int>();
            foreach (int n in numbers)
            {
                if (numbers.IndexOf(n) != numbers.LastIndexOf(n) && !filteredList.Contains(n))
                {
                    filteredList.Add(n);
                }
            }
            return filteredList;
        }

        static void Main(string[] args)
        {
            List<int> queue = new List<int>();
            int[] elements = { 2, 5, 5, 7, 2, 4, 1, 3, 2, 5, 5, 1 };
            foreach (int element in elements)
            {
                queue.Add(element);
            }

            


        }
    }
}
