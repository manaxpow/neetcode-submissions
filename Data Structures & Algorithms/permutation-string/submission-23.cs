public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        var dict = new Dictionary<char,int>();
        int l=0,r=0;
        int count =0;
        while(r<s1.Length)
        {
            dict[s1[r]] = dict.GetValueOrDefault(s1[r] ,0 ) +1;
            r++;
        }
        r=0;
        while(r<s2.Length)
        {
            if(dict.ContainsKey(s2[r]) )
            {
                dict[s2[r]] -= 1;
                count++;
                while(dict[s2[r]] <0)
                {
                    if(dict.ContainsKey(s2[l]))
                    {
                        dict[s2[l]] +=1;
                        count--;
                    }
                    l++;
                }
                if(count == s1.Length) return true;
            }
            else
            {
                while(l<r)
                {
                    if(dict.ContainsKey(s2[l]))
                    {
                        dict[s2[l]] +=1;
                    }
                    l++;
                }
                count =0;
            }
            r++;
        }
        return false;
    }
}
