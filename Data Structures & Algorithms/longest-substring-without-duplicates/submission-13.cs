public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <2) return s.Length;
        int result = 0, l=0,r=0;
        var hash = new HashSet<char>();

        while(r<s.Length)
        {
            if(hash.Contains(s[r]))
            {
               hash.Remove(s[l]);
                l++;
            }
            else{
                
                 hash.Add(s[r]);
                r++;
                result = Math.Max(result, r-l);
            }
        }
        return result;
    }
}
