using LeetCodeUtility;
using System;
using System.Collections.Generic;

namespace LeetCodeSolutions
{
    /**
     * https://leetcode.com/problems/add-two-numbers/
     *
     */

    public static class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            var listNode = new ListNode(0);
            var p = l1;
            var q = l2;
            int carry = 0;
            var currentNode = listNode;

            while (p != null || q != null)
            {
                int top = p?.val ?? 0;
                int bottom = q?.val ?? 0;

                int sum = carry + top + bottom;
                carry = sum / 10;

                currentNode.next = new ListNode(sum % 10);
                currentNode = currentNode.next;

                p = p?.next;
                q = q?.next;
            }

            if (carry != 0)
            {
                currentNode.next = new ListNode(carry);
            }

            return listNode.next;
        }
    }

    public class ListNode : ValueObject
    {
        public int val;

        public ListNode next;

        public ListNode(int x) => val = x;

        public ListNode(int[] data)
        {
            val = data[0];

            var currentListNode = this;

            for (int i = 1; i < data.Length; i++)
            {
                currentListNode.next = new ListNode(data[i]);
                currentListNode = currentListNode.next;
            }
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return val;
            yield return next;
        }

        public static ListNode operator +(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers.Solution(l1, l2);
        }
    }
}
