using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class AddTwoNumbersClass
    {
        public static void Test()
        {
            ListNode l1_1 = new ListNode(9);
            ListNode l1_2 = new ListNode(9);
            var r1 = AddTwoNumbers(l1_1, l1_2);

            ListNode l2_1 = new ListNode(1);
            l2_1.next = new ListNode(8);
            ListNode l2_2 = new ListNode(0);
            var r2 = AddTwoNumbers(l2_1, l2_2);


            ListNode l3_1 = new ListNode(1);
            ListNode l3_2 = new ListNode(9);
            l3_2.next = new ListNode(9);
            var r3 = AddTwoNumbers(l3_1, l3_2);



            ListNode l4_1 = new ListNode(2);
            l4_1.next = new ListNode(4);
            l4_1.next.next = new ListNode(3);

            ListNode l4_2 = new ListNode(5);
            l4_2.next = new ListNode(6);
            l4_2.next.next = new ListNode(4);
                       
            var r = AddTwoNumbers(l4_1, l4_2);


            ListNode l5_1 = new ListNode(9);
            l5_1.next = new ListNode(1);
            l5_1.next.next = new ListNode(6);

            ListNode l5_2 = new ListNode(0);

            var r5 = AddTwoNumbers(l5_1, l5_2);

        }

        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers(l1, l2, 0);

        }

        private static ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry)
        {
            
            int val = (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val) + carry;
            int _nextCarry = 0;
            if (val >= 10)
            {
                val = val - 10;
                _nextCarry = 1;
            }
            ListNode r = new ListNode(val);
            

            if (l1?.next != null || l2?.next != null)
            {
                r.next = AddTwoNumbers(l1?.next, l2?.next, _nextCarry);
            }
            else
            {
                if (_nextCarry > 0)
                {
                    r.next = new ListNode(_nextCarry);
                }
            }

            return r;
        }


    }
}
