public class Solution {
    public string Encode(IList<string> strs) {
        List<char> chars = new List<char>();

        foreach (string str in strs) {
            chars.Add((char)str.Length);
            chars.Add('#');
            foreach (char c in str) {
                chars.Add(c);
            }
        }
        return new string(chars.ToArray());
    }

    public List<string> Decode(string s) {
        List<string> result = new List<string>();
        int i = 0;
        while (i < s.Length) {
            if (i+1< s.Length && s[i + 1] == '#') {
                int length = (int)s[i];
                i+= 2;
                int targetEnd = i+length;
                List<char> word = new List<char>();
                while(i<targetEnd)
                {
                    word.Add(s[i]);
                    i++;
                }
                result.Add(new string(word.ToArray()));
            }
            else
            {
                i++;
            }
        }
        return result;
    }
}
