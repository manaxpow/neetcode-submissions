public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        var minHeap = new PriorityQueue<int, int>();

        foreach (int num in nums) {
            if (minHeap.Count >= k) {
                if (num > minHeap.Peek()) {
                    minHeap.Dequeue();
                } else
                    continue;
            }

            minHeap.Enqueue(num, num);
        }

        return minHeap.Peek();
    }
}
