public class Solution {
    public int FindDuplicate(int[] nums) {
        var set = new HashSet<int>();

        foreach(int i in nums)
        {
            if(!set.Add(i))
            {
                return i;
            }
        }
        return -1;
    }
}
