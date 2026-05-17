public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int max =0;

        foreach(int i in piles)
        {
            max = Math.Max(max,i);
        }

        int l=1,r= max;
        int pivot = l+(r-l)/2;

        while(l<=r)
        {
            int time =0;
            foreach(int i in piles)
            {
                // ceiling
                time += (int)Math.Ceiling((decimal)i/pivot);
            }
            if(time <=h) 
            {
                r = pivot-1;
                max=pivot;
            }
            else l= pivot+1;
            pivot = l+(r-l)/2;
        }
        return max;
    }
}
