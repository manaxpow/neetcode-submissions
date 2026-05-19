public class Solution {
    public int FindMin(int[] nums) {
        int l=0, r=nums.Length-1;
        if(nums[l] < nums[r]) return nums[l];
        int pivot =(r-l) /2;

        while(l<=r)
        {
            if(nums[pivot] == nums[r]) return nums[pivot];
            if(nums[pivot] > nums[r])
            {
                l= pivot+1;
            }
            else
            {
                r= pivot;
            }
            pivot = l+(r-l)/2;
        }
        return nums[pivot];
    }
}
