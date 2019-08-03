namespace LeetCodeSolutions
{
    public class AddTwoNumbers
    {
        public static ListNode Solution(ListNode l1, ListNode l2)
        {
            return new ListNode(0);
        }
    }

    public class ListNode
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

        public static ListNode operator +(ListNode l1, ListNode l2)
        {
            return AddTwoNumbers.Solution(l1, l2);
        }
    }
}
