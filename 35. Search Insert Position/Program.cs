using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35.Search_Insert_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mynums = { 1, 3, 5, 7};
            int mytarget = 0;

            foreach (int mynum in mynums)
            {
                Console.Write($"{ Convert.ToString(mynum)}  ");
            }
            Console.WriteLine();
            Console.WriteLine(Convert.ToString(mytarget));
            Console.WriteLine(Convert.ToString(SearchInsert(mynums, mytarget)));
            Console.Read();


            int SearchInsert(int[] nums, int target)
            {
                int left = 0, right = nums.Length-1, mid;

                while (left <= right)
                {
                    mid = (right + left) / 2;

                    if (nums[mid] < target)
                    {
                        left = mid + 1;
                    }

                    else if (nums[mid] > target)
                    {
                        right = mid - 1;
                    }

                    else
                    {
                        return mid;
                    }

                }
                return left;

            }

        }
    }
}
