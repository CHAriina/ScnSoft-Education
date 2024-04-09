namespace LeetCodeTraining.RemoveNthNodeFromEndOfList18
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for (int count = 0; count <= n; count++)
            {
                if (first == null) return head; 
                first = first.next;
            }

            if (first == null) return head; 

            while (first != null)
            {
                first = first.next;
                second = second.next;
            }

            second.next = second.next.next;

            return dummy.next;
        }
    }
}
