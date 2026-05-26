public class KthLargest {
    private PriorityQueue<int, int> _minHeap;
    private int k;
    public KthLargest(int k, int[] nums) {
        _minHeap = new PriorityQueue<int, int>();
        this.k = k;
        foreach (int i in nums) {
            if (_minHeap.Count >= k) {
                if (i > _minHeap.Peek()) {
                    _minHeap.Dequeue();
                } else
                    continue;
            }
            _minHeap.Enqueue(i, i);
        }
    }

    public int Add(int val) {
        if (_minHeap.Count >= k) {
            if (val > _minHeap.Peek()) {
                _minHeap.Dequeue();
            } else
                return _minHeap.Peek();
        }
        _minHeap.Enqueue(val, val);
        return _minHeap.Peek();
    }
}
