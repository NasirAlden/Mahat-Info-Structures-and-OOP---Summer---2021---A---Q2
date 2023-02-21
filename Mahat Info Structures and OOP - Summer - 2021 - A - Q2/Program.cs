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
            int count = 0;
            foreach (int n in numbers)
            {
                for (int i = numbers.IndexOf(n); i < numbers.Count() - 1; i++) {
                    if (n == numbers[i])
                        count++;
                }
                if (count >=3 && !filteredList.Contains(n))
                    filteredList.Add(n);
                count=0;
            }
            return filteredList;
        }
        static void Main(string[] args)
        {

            List<int> queue = new List<int>();
            List<int> filteredQueue = new List<int>();

            int[] elements = { 2, 5, 5, 7, 2, 4, 1, 3, 2, 5, 5, 1 };
            foreach (int element in elements)
            {
                queue.Add(element);
            }

            filteredQueue= FilterDuplicates(queue);
            Console.WriteLine(String.Join(",", filteredQueue)); 
        }
    }
}
