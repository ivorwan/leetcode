using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class ReverseClass
    {
        public void Test()
        {
            int i1 = 123;
            var s1 = Reverse(i1);

            int i2 = -123;
            var s2 = Reverse(i2);

            int i3 = 120;
            var s3 = Reverse(i3);

            int i4 = 1534236469;
            var s4 = Reverse(i4);
        }
        public int Reverse(int x)
        {

            int n = x;
            int result = 0;
            while (n != 0)
            {
                int pop = n % 10;
                if (result > Int32.MaxValue / 10 || (result == Int32.MaxValue && pop > 7)) return 0;
                if (result < Int32.MinValue / 10 || (result == Int32.MinValue && pop < -8)) return 0;
                result = result * 10 + pop;
                n = n / 10;
            }
            return result;
        }

    }
}
