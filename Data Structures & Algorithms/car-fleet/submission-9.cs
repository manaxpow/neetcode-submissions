public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        
        int []indices = new int [n];

        for(int i=0; i<n; i++)
        {
            indices[i]=i;
        }

        Array.Sort(indices,(a,b)=> position[b].CompareTo(position[a]));
        
        int result=0;
        double max =0;

        for(int j=0; j<n;j++)
        {
            double exTime = (double)(target- position[indices[j]])/ speed[indices[j]];
            if(exTime > max)
            {
                max = exTime; 
                result++;
            }
        }
        return result;
    }
}
