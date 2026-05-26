public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var maxHeap = new PriorityQueue<int[],double>(Comparer<double>.Create((x,y)=> y.CompareTo(x)));
        foreach(int[] point in points)
        {
            double distance = Math.Sqrt(Math.Pow(point[0],2) + Math.Pow(point[1],2));
            if(maxHeap.Count >= k)
            {
                double max = Math.Sqrt(Math.Pow(maxHeap.Peek()[0],2) + Math.Pow(maxHeap.Peek()[1],2));
                if(distance < max)
                {
                    maxHeap.Dequeue();
                }
                else continue;
            }
            maxHeap.Enqueue(point,distance);
        }

        int[][] result = new int[k][];
        while(maxHeap.Count >0)
        {
            result[maxHeap.Count-1] = maxHeap.Dequeue();
        }
        return result;
    }
}
