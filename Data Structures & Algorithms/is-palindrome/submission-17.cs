public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrWhiteSpace(s)) return true;

        List<char> chars = new List<char>();

        for(int i=0;i<s.Length;i++)
        {
            if(!Char.IsLetter(s[i]) && !Char.IsDigit(s[i])) continue;

            if(Char.IsLetter(s[i])) chars.Add(Char.ToLower(s[i]));
            else chars.Add(s[i]);
        }

        int l = 0;
        int r = chars.Count - 1;

        while(l<r)
        {
            if(chars[l] != chars[r])
            {
                return false;
            } 
            else
            {
                l++;
                r--;
            }
        }
        return true;
    }
}
