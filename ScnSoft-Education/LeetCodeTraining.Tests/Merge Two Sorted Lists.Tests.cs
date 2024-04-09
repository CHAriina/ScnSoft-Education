using LeetCodeTraining.MergeTwoSortedLists20;

namespace LeetCodeTraining.Tests.MergeTwoSortedLists20
{
    public class SolutionTests
    {
        [Theory]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 1, 3, 4 }, new int[] { 1, 1, 2, 3, 4, 4 })]
        [InlineData(new int[] { }, new int[] { }, new int[] { })]
        [InlineData(new int[] { }, new int[] { 0 }, new int[] { 0 })]
        [InlineData(new int[] { 1, 2, 4 }, new int[] { 5, 6, 7 }, new int[] { 1, 2, 4, 5, 6, 7 })]
        public void TestMergeTwoLists(int[] arr1, int[] arr2, int[] expected)
        {
            // Arrange
            ListNode list1 = CreateLinkedList(arr1);
            ListNode list2 = CreateLinkedList(arr2);
            Solution solution = new Solution();

            // Act
            ListNode result = solution.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(expected, ConvertLinkedListToArray(result));
        }

        private ListNode CreateLinkedList(int[] arr)
        {
            ListNode dummyHead = new ListNode();
            ListNode current = dummyHead;
            foreach (int val in arr)
            {
                current.next = new ListNode(val);
                current = current.next;
            }
            return dummyHead.next;
        }

        private int[] ConvertLinkedListToArray(ListNode head)
        {
            List<int> result = new List<int>();
            ListNode current = head;
            while (current != null)
            {
                result.Add(current.val);
                current = current.next;
            }
            return result.ToArray();
        }
    }
}
