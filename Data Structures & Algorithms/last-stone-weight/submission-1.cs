public class Solution {
    public int LastStoneWeight(int[] stones) {
        var maxHeap = new PriorityQueue<int,int>(Comparer<int>.Create((x,y)=>y.CompareTo(x)));

        foreach(int stone in stones)
        {
            maxHeap.Enqueue(stone,stone);
        }

        while(maxHeap.Count >1)
        {
            int remain = maxHeap.Dequeue() - maxHeap.Dequeue();
            if(remain != 0)
            {
                maxHeap.Enqueue(remain,remain);
            }
        }
        return maxHeap.Count == 0 ? 0 : maxHeap.Dequeue();
    }
}
