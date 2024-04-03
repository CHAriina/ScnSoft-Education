namespace LeetCodeTraining.AddTwoNumbers9
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
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode currentNodeL1 = l1, currentNodeL2 = l2, resultNode = dummyHead;
            int carry = 0;

            while (currentNodeL1 != null || currentNodeL2 != null)
            {
                int value1 = (currentNodeL1 != null) ? currentNodeL1.val : 0;
                int value2 = (currentNodeL2 != null) ? currentNodeL2.val : 0;
                int sum = carry + value1 + value2;
                carry = sum / 10;

                resultNode.next = new ListNode(sum % 10);
                resultNode = resultNode.next;

                if (currentNodeL1 != null) currentNodeL1 = currentNodeL1.next;
                if (currentNodeL2 != null) currentNodeL2 = currentNodeL2.next;
            }

            if (carry > 0)
            {
                resultNode.next = new ListNode(carry);
            }

            return dummyHead.next;
        }
    }

}
