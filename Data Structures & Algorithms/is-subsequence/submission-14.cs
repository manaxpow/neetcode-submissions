public class Solution {
    public bool IsSubsequence(string s, string t) {
        if(string.IsNullOrWhiteSpace(t)) return false;
        if(string.IsNullOrWhiteSpace(s)) return true;

        int cur =0;
        for(int i=0 ; i< t.Length; i++)
        {
            if(t[i] == s[cur])
            {
                cur++;
                if(cur == s.Length) return true;
            }
        }
        if(cur != s.Length) return false;
        return true;
    }
}