using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class FindMedianSortedArraysClass
    {
        public void Test()
        {
            int[] i1_1 = new int[] { 1, 3 };
            int[] i1_2 = new int[] { 2 };

            var r1 = FindMedianSortedArrays(i1_1, i1_2);

            int[] i2_1 = new int[] { 1, 2 };
            int[] i2_2 = new int[] { 3, 4 };

            var r2 = FindMedianSortedArrays(i2_1, i2_2);


        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length + nums2.Length;

            int[] final_array = new int[m];

            int p1 = 0;
            int p2 = 0;

            int j = 0;
            while (j < m)
            {
                if (p1 < nums1.Length && p2 < nums2.Length)
                {
                    if (nums1[p1] < nums2[p2])
                    {
                        final_array[j] = nums1[p1];
                        p1++;
                    }
                    else
                    {
                        final_array[j] = nums2[p2];
                        p2++;
                    }
                }
                else if (p1 < nums1.Length)
                {
                    final_array[j] = nums1[p1];
                    p1++;
                }
                else
                {
                    final_array[j] = nums2[p2];
                    p2++;
                }
                j++;


                
            }

            if (m%2 > 0)
            {

                return final_array[(m - 1) / 2];
            }
            else
            {
                int int1 = final_array[(m / 2)-1];
                int int2 = final_array[(m / 2)];

                return (double)(int1 + int2) / 2;
                
            }
        }
    }
}
    
