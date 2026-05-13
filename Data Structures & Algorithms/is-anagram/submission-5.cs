public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var dict = new Dictionary <char, int>();

        for (int i=0; i<s.Length; i++)
        {
            var current = s[i];
            dict[current] = dict.GetValueOrDefault(current,0) +1;
        }
        
        for(int c =0; c<t.Length; c++)
        {
            var current = t[c];
            dict[current] = dict.GetValueOrDefault(current,0) -1;
            if(dict[t[c]] <0) return false;
        }

        foreach(var dictItem in dict)
        {
            if(dictItem.Value !=0) return false;
        }
        return true;
    }
}
