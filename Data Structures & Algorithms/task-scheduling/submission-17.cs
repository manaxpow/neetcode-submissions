public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int[] frequent = new int[26];
        foreach (char i in tasks) {
            frequent[i - 'A']++;
        }

        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < 26; i++) {
            if (frequent[i] > 0) {
                maxHeap.Enqueue(frequent[i], frequent[i]);
            }
        }

        var queue = new Queue<(int remFreq, int availableTime)>();
        int time = 0;
        while (maxHeap.Count > 0 || queue.Count > 0) {
            time++;
            if(maxHeap.Count > 0) {
                var cur = maxHeap.Dequeue();

                if (cur > 1) {
                    queue.Enqueue((cur -1, n + time + 1));
                }
            }

            if (queue.Count > 0 && queue.Peek().availableTime <= time + 1) {
                var cur = queue.Dequeue();
                maxHeap.Enqueue(cur.remFreq, cur.remFreq);
            }
        }
        return time;
    }
}
