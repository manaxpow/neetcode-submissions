public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> result = new List<List<int>>();
        Array.Sort(nums);

        int l,r;
        for(int i=0;i<nums.Length -2; i++)
        {
            if(i >0 && nums[i] == nums[i-1]) continue;
            l= i+1;
            r=nums.Length-1;
            while(l<r)
            {
                int sum = nums[i] + nums[l] + nums[r];
                if(sum == 0)
                {
                    result.Add(new List<int>{nums[i],nums[l],nums[r]});

                    while(l<r && nums[l] == nums[l+1]) l++;
                    while(l<r && nums[r] == nums[r-1]) r--;

                }
                if(sum<0)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }
        }

        return result;
    }
}
