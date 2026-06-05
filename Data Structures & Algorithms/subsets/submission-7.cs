public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        BackTracking(0, nums, result, new List<int>());
        return result;
    }

    private void BackTracking(int cur, int[] nums, List<List<int>> result, List<int> path) {
        result.Add(new List<int>(path));

        for (int i = cur; i < nums.Length; i++) {
            path.Add(nums[i]);

            BackTracking(i + 1, nums, result, path);

            path.RemoveAt(path.Count - 1);
        }
    }
}
