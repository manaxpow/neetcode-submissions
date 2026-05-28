public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length <= 1)
            return nums.Length;

        var dict = new Dictionary<int, int>();
        int max = 1;

        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                dict[num] = 1;
                if (dict.TryGetValue(num - 1, out int val)) {
                    dict[num] += val;
                    int cur = num -1;
                    while(dict.ContainsKey(cur))
                    {
                        cur--;
                    }
                    dict[cur+1] = dict[num];
                    max = Math.Max(max,dict[num] );
                }
                if (dict.ContainsKey(num + 1)) {
                    dict[num + 1] += dict[num];
                    int cur = num -1;
                    while(dict.ContainsKey(cur))
                    {
                        cur--;
                    }
                    dict[cur+1] = dict[num + 1];
                    max = Math.Max(max, dict[num +1]);
                }
            }
        }
        return max;
    }
}
