public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var dict = new Dictionary<string,List<string>>();
        for(int i=0; i< strs.Length;i++)
        {
            string cur = strs[i];
            int [] charFrequent = new int [26];
            // count the character frequency of the string
            foreach(char c in cur)
            {
                charFrequent[c - 'a'] ++;
            }

            string key = String.Join('#',charFrequent);
            // add if exist
            if(!dict.ContainsKey(key))
            {
                dict[key] = new List<string>();
            }
            dict[key].Add(strs[i]);
        }
        return dict.Values.ToList<List<string>>();
    }
}
