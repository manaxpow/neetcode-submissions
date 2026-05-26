public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var maxHeap =
            new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (int[] point in points) {
            int squareDistance = point[0]*point[0]  + point[1] *point[1];
            if (maxHeap.Count >= k) {
                maxHeap.TryPeek(out int []_, out int maxDistance);
                if (squareDistance < maxDistance) {
                    maxHeap.Dequeue();
                } else
                    continue;
            }
            maxHeap.Enqueue(point, squareDistance);
        }

        int[][] result = new int [k][];
        while (maxHeap.Count > 0) {
            result[maxHeap.Count - 1] = maxHeap.Dequeue();
        }
        return result;
    }
}
