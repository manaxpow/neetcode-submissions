public class Solution {
    public int CharacterReplacement(string s, int k) {
        var dict = new Dictionary<char,int> ();
        int l=0,r =0;
        int result =0;
        int maxf =0;
        while(r<s.Length)
        {
            dict[s[r]] = dict.GetValueOrDefault(s[r],0) +1;
            
            foreach(int i in dict.Values)
            {
                maxf = Math.Max(maxf,i);
            }

            while(r-l+1 - maxf > k)
            {
                dict[s[l]] -= 1;
                l++;     
            }

            result = Math.Max(result, r-l+1);
            r++;
        }
        return result;
    }
}
