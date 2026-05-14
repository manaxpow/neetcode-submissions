public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        foreach(int [] m in matrix)
        {
            if(m[m.Length-1] < target) continue;

            int l =0, r = m.Length-1;
            int pivot = (r-l) /2;

            while(l<=r)
            {
                if(m[pivot] == target)
                    return true;
                if(m[pivot] >target)
                    r= pivot -1;
                else
                    l=pivot +1;
                pivot = l+(r-l)/2;
            }
        }
        return false;
    }
}
