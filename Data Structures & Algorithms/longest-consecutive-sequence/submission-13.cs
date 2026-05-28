public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length <= 1)
            return nums.Length;

        var dict = new Dictionary<int, int>();
        int max = 1;

        foreach (int num in nums) {
            if (!dict.ContainsKey(num)) {
                int left = dict.ContainsKey(num - 1) ? dict[num-1] : 0;
                int right = dict.ContainsKey(num + 1) ? dict[num+1] : 0;

                int sum = left + right +1;
                dict[num] = sum;
                max = Math.Max(max, sum);
                dict[num-left] = sum;
                dict[num+ right]= sum;  
            }
        }
        return max;
    }
}