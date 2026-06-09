public class Solution {
    public List<List<int>> SubsetsWithDup(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        BackTracking(nums, 0, new List<int>(), result);
        return result;
    }

    private void BackTracking(int[] nums, int cur, List<int> path, List<List<int>> result) {
        result.Add(new List<int>(path));

        for (int i = cur; i < nums.Length; i++) {
            if (i > cur && nums[i] == nums[i - 1])
                continue;
            path.Add(nums[i]);
            BackTracking(nums, i + 1, path, result);
            path.RemoveAt(path.Count - 1);
        }
    }
}
