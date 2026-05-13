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
                if(nums[l]== nums[l-1] && l>i+1)
                {
                    l++;
                    continue;
                }
                if(r+1 < nums.Length && nums[r] == nums[r+1])
                {
                    r--;
                    continue;
                }

                if(-nums[i] == nums[l] + nums[r])
                {
                    var item = new List<int>();
                    item.Add(nums[i]);
                    item.Add(nums[l]);
                    item.Add(nums[r]);
                    result.Add(item);
                }
                if(-nums[i] > nums[l] + nums[r])
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
