public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int ,int >();
        foreach(int n in nums)
        {
            if(!dict.ContainsKey(n))
            {
                dict[n]=0;
            }
            dict[n] +=1;
        }

        var minHeap = new PriorityQueue<int, int>();

        foreach(KeyValuePair<int, int> i in dict)
        {
            if(minHeap.Count >= k)
            {
                var min = minHeap.TryPeek(out int number, out int frequent);
                if(i.Value > frequent)
                {
                    minHeap.Dequeue();
                }
                else
                continue;
            }
            minHeap.Enqueue(i.Key, i.Value);
        }

        int [] result = new int[minHeap.Count];
        while(minHeap.Count >0)
        {
            result[minHeap.Count -1] = minHeap.Dequeue();
        }
        
        return result;
    }   
}
