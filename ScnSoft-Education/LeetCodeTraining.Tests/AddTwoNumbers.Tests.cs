using LeetCodeTraining.AddTwoNumbers9;
namespace AddTwoNumbersTests
{
    public class AddTwoNumbersTests
    {
        [Theory]
        [InlineData(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
        [InlineData(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
        public void TestAddTwoNumbers(int[] input1, int[] input2, int[] expected)
        {
            ListNode l1 = CreateLinkedList(input1);
            ListNode l2 = CreateLinkedList(input2);

            Solution solution = new Solution();
            ListNode result = solution.AddTwoNumbers(l1, l2);

            ListNode expectedList = CreateLinkedList(expected);

            while (expectedList != null)
            {
                Assert.Equal(expectedList.val, result.val);
                expectedList = expectedList.next;
                result = result.next;
            }
        }

        private ListNode CreateLinkedList(int[] values)
        {
            if (values == null || values.Length == 0)
                return null;

            ListNode head = new ListNode(values[0]);
            ListNode current = head;

            for (int i = 1; i < values.Length; i++)
            {
                current.next = new ListNode(values[i]);
                current = current.next;
            }

            return head;
        }
    }
}
