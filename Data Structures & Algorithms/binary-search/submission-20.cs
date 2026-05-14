public class Solution {
    public int Search(int[] nums, int target) {
        int l =0, r = nums.Length-1;
        int pivot = (r-l) /2;
        while(l<=r)
        {
            if(nums[pivot] == target)
                return pivot;
            
            if (nums[pivot] > target)
                r= pivot-1;
            else
                l=pivot+1;

            pivot = l+ (r-l)/2;
        }

        return -1;
    }
}
