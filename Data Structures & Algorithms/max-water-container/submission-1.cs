public class Solution {
    public int MaxArea(int[] heights) {
        int l=0,r=heights.Length-1;
        int result = 0;
        while(l<=r)
        {
            result = Math.Max(result,Math.Min(heights[l],heights[r])*(r-l));
            if(heights[l]<=heights[r])
            {
                l++;
            }
            else
            {
                r--;
            }
        }

        return result;
    }
}
