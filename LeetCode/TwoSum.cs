using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class TwoSumClass
    {
        public static int[] TwoSum(int[] nums, int target)
        {

            int[] r = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i != j && (nums[i] + nums[j] == target))
                    {
                        r[0] = i;
                        r[1] = j;
                        Console.Write(i);
                        Console.Write("+");
                        Console.Write(j);
                        return r;
                    }

                }

            }

            return null;
        }
    }
}
