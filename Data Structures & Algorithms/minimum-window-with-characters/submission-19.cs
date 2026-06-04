public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length)
            return "";

        var dict = new Dictionary<char, int>();

        foreach (char c in t) {
            if (!dict.ContainsKey(c)) {
                dict[c] = 0;
            }
            dict[c] += 1;
        }

        int l = 0, r = 0;
        int have = 0, need = dict.Count;
        var window = new Dictionary<char, int>();
        int start =0;
        int lengthOfResult = Int32.MaxValue;
        while (r < s.Length) {
            if (dict.ContainsKey(s[r])) {
                if (!window.ContainsKey(s[r])) {
                    window[s[r]] = 0;
                }
                window[s[r]] += 1;
                if (window[s[r]] == dict[s[r]])
                    have++;
            }
            while (have == need) {
                if (r - l + 1 < lengthOfResult) {
                    lengthOfResult = r - l + 1;
                    start = l;
                }
                if (window.ContainsKey(s[l])) {
                    window[s[l]] -= 1;
                    if (window[s[l]] < dict[s[l]]) {
                        have--;
                    }
                }
                l++;
            }
            r++;
        }

        return lengthOfResult == Int32.MaxValue ? "" : s.Substring(start, lengthOfResult);
    }
}
