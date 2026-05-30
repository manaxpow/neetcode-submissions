public class Solution {
    public int Trap(int[] height) {
        int [] prefix = new int [height.Length];
        int [] suffix = new int [height.Length];

        int i =0;
        int max =0;
        while(i < height.Length)
        {
            if(i==0)
            {
                prefix[i]=0;
            }
            else
            {
                max = Math.Max(max, height[i-1]);
                prefix[i] = max;
            }
            i++;
        }
        i= height.Length-1;
        max =0;
        while(i > 0)
        {
            if(i== height.Length-1)
            {
                suffix[i]=0;
            }
            else
            {
                max = Math.Max(max, height[i+1]);
                suffix[i] = max;
            }
            prefix[i] = Math.Min(prefix[i], suffix[i]);
            i--;
        }

        int result =0;
        for(int j=0; j< prefix.Length; j++)
        {
            if(prefix[j] - height[j] >= 0) result += prefix[j] - height[j];
        }

        return result;
    }
}
