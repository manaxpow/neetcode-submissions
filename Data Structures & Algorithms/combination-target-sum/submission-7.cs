public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        BackTracking(0, target, nums, new List<int>(), 0, result);

        return result;
    }

    private void BackTracking(int curent, int target, int[] nums, List<int> curentPath, int total,
                              List<List<int>> result) {
        if (total == target) {
            result.Add(new List<int>(curentPath));
            return;
        }
        if (total > target) {
            return;
        }

        for (int i = curent; i < nums.Length; i++) {
            curentPath.Add(nums[i]);
            BackTracking(i, target, nums, curentPath, total + nums[i], result);

            curentPath.RemoveAt(curentPath.Count - 1);
        }
    }
}
