using LeetCodeTraining.RemoveNthNodeFromEndOfList18;

namespace LeetCodeTraining.Tests.RemoveNthNodeFromEndOfList
{
    public class RemoveNthNodeFromEndOfListTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 2, new int[] { 1, 2, 3, 5 })]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, 1, new int[] { 1, 2, 3, 4 })]
        public void Test_RemoveNthFromEnd(int[] inputValues, int n, int[] expectedValues)
        {
            // Arrange
            ListNode head = CreateLinkedList(inputValues);
            Solution solution = new Solution();
            // Act
            head = solution.RemoveNthFromEnd(head, n);

            // Assert
            ListNode current = head;
            for (int i = 0; i < expectedValues.Length; i++)
            {
                Assert.Equal(expectedValues[i], current.val);
                current = current.next;
            }
        }

        private ListNode CreateLinkedList(int[] values)
        {
            ListNode dummy = new ListNode(0);
            ListNode current = dummy;

            foreach (int value in values)
            {
                current.next = new ListNode(value);
                current = current.next;
            }

            return dummy.next;
        }
    }
}
