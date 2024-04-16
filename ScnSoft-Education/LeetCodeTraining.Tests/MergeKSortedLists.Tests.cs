using LeetCodeTraining.MergeKSortedLists22;

namespace LeetCodeTraining.Tests.MergeKSortedLists
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 4, 5 }, new int[] { 1, 3, 4 }, new int[] { 2, 6 }, new int[] { 1, 1, 2, 3, 4, 4, 5, 6 })]
        [InlineData(new int[] { }, new int[] { 1 }, new int[] { 2 }, new int[] { 1, 2 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { }, new int[] { })]
        public void MergeKLists_ValidInput_ReturnsMergedSortedLinkedList(int[] input1, int[] input2, int[] input3, int[] expected)
        {
            // Arrange
            ListNode list1 = CreateLinkedList(input1);
            ListNode list2 = CreateLinkedList(input2);
            ListNode list3 = CreateLinkedList(input3);

            ListNode[] lists = new ListNode[] { list1, list2, list3 };
            Solution solution = new Solution();

            // Act
            ListNode result = solution.MergeKLists(lists);

            // Assert
            List<int> actualValues = new List<int>();
            ListNode current = result;
            while (current != null)
            {
                actualValues.Add(current.val);
                current = current.next;
            }

            Assert.Equal(expected, actualValues);
        }

        private ListNode CreateLinkedList(int[] values)
        {
            ListNode head = new ListNode();
            ListNode current = head;
            foreach (int val in values)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return head.next;
        }
    }
}
