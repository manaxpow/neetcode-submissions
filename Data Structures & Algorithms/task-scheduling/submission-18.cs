public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        // count the frequency of char
        int[] frequent = new int[26];
        foreach (char i in tasks) {
            frequent[i - 'A']++;
        }

        // enqueue to maxHeap(finding the largest frequency)
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y.CompareTo(x)));
        for (int i = 0; i < 26; i++) {
            if (frequent[i] > 0) {
                maxHeap.Enqueue(frequent[i], frequent[i]);
            }
        }

        // using queue to track the cooldown time of char
        var queue = new Queue<(int remFreq, int availableTime)>();
        int time = 0;
        while (maxHeap.Count > 0 || queue.Count > 0) {
            time++;
            // dequeue maxHeap and enqueue to queue if remaining frequency
            if(maxHeap.Count > 0) {
                var cur = maxHeap.Dequeue();

                if (cur > 1) {
                    queue.Enqueue((cur -1, n + time + 1));
                }
            }
            
            // push char to maxHeap if it is available
            if (queue.Count > 0 && queue.Peek().availableTime <= time + 1) {
                var cur = queue.Dequeue();
                maxHeap.Enqueue(cur.remFreq, cur.remFreq);
            }
        }
        return time;
    }
}
