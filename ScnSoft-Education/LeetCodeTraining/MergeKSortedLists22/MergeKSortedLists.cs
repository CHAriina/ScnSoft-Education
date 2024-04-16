namespace LeetCodeTraining.MergeKSortedLists22
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
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
            {
                return null;
            }

            ListNode result = new ListNode();
            ListNode current = result;
            List<int> values = new List<int>();

            foreach (var list in lists)
            {
                ListNode temp = list;
                while (temp != null)
                {
                    values.Add(temp.val);
                    temp = temp.next;
                }
            }

            values.Sort();

            foreach (var val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }

            return result.next;
        }
    }
}
