public class Solution {
    public int Trap(int[] height) {
        int left = 0;
        int right = height.Length - 1;
        int maxLeft = 0, maxRight = 0;
        int result = 0;

        while (left < right) {
            // checking if height left < heigh right => maxLeft alway < maxRight
            // so we don't need to calculate min of them
            if (height[left] < height[right]) {
                if(height[left] > maxLeft)
                {
                    maxLeft = height[left];
                }
                else    
                {
                    // trapped water of index = maxLeft - it's height
                    result += maxLeft- height[left];
                }
                left++;
            }
            // vice versa 
            else
            {
                if(height[right] > maxRight)
                {
                    maxRight = height[right];
                }
                else    
                {
                    result += maxRight- height[right];
                }
                right--;
            }
            
        }
        return result;
    }
}
