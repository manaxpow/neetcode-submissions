public class Solution {
    public int Search(int[] nums, int target) {
        int left = 0, right = nums.Length - 1;
        int pivot = (right - left) / 2;
        while (left <= right) {
            if (nums[pivot] == target)
                return pivot;
            bool isLeftOrderSorted = nums[left] <= nums[pivot];
            bool isRightOrderSorted = nums[pivot] <= nums[right];

            bool isTargetInLeft = target >= nums[left] && target < nums[pivot];
            bool isTargetInRight = target <= nums[right] && target > nums[pivot];

            if (isLeftOrderSorted) {
                if (isTargetInLeft)
                    right = pivot - 1;
                else
                    left = pivot + 1;
            } else if (isRightOrderSorted) {
                if (isTargetInRight)
                    left = pivot + 1;
                else
                    right = pivot - 1;
            }
            pivot = left + (right - left) / 2;
        }
        return -1;
    }
}
