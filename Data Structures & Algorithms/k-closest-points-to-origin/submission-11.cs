public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        var maxHeap =
            new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        foreach (int[] point in points) {
            // square diction is more efficient than using Math.Pow
            // puzzle just need point so do not need to calculate the real distance
            int squareDistance = point[0]*point[0]  + point[1] *point[1];
            if (maxHeap.Count >= k) {
                // using trypeak for getting the priority 
                maxHeap.TryPeek(out int []_, out int maxDistance);
                if (squareDistance < maxDistance) {
                    maxHeap.Dequeue();
                } else
                    continue;
            }
            maxHeap.Enqueue(point, squareDistance);
        }

        // init array with k
        int[][] result = new int [k][];
        while (maxHeap.Count > 0) {
            result[maxHeap.Count - 1] = maxHeap.Dequeue();
        }
        return result;
    }
}
