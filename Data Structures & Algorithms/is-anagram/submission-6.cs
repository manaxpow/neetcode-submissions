public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict = new Dictionary <char, int>();

        for (int i=0; i<s.Length; i++)
        {
            dict[s[i]] = dict.GetValueOrDefault(s[i],0) +1;
            dict[t[i]] = dict.GetValueOrDefault(t[i],0) -1;
        }
        
        foreach(var dictItem in dict)
        {
            if(dictItem.Value !=0) return false;
        }
        return true;
    }
}
