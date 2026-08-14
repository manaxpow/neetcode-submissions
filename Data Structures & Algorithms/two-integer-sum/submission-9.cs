public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int,int>();

        for(int i=0; i< nums.Length; i++)
        {
            if(dict.TryGetValue(target - nums[i], out int c))
            {
                return [c,i];
            }
            dict[nums[i]] = i;
        }

        return [0,0];
    }
}
