public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        var result = new List<List<int>>();
        BackTracking(0, nums, result, new List<int>());
        return result;
    }

    private void BackTracking(int cur, int[] nums, List<List<int>> result, List<int> path) {
        if (cur == nums.Length) {
            result.Add(new List<int>(path));
            return;
        }

        path.Add(nums[cur]);
        BackTracking(cur + 1, nums, result, path);

        path.RemoveAt(path.Count - 1);
        BackTracking(cur+1, nums, result, path);
    }
}
