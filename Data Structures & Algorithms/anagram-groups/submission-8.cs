public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        List<List<string>> result = new List<List<string>>();
        if(strs.Length ==1)
        {
            result.Add(new List<string> {strs[0]});
            return result;
        } 

        var dict = new Dictionary<string,List<string>>();
        for(int i=0; i< strs.Length;i++)
        {
            string cur = strs[i];
            int [] charFrequent = new int [26];
            // count the character frequency of the string
            for(int j=0;j<cur.Length;j++)
            {
                charFrequent[cur[j]-'a'] += 1;
            }
            string key = String.Join('#',charFrequent);
            // add if exist
            if(dict.TryGetValue(key, out List<string> list))
            {
                list.Add(strs[i]);
                dict[key]= list;
            }
            // create new
            else
            {
                dict[key] = new List<string>(){strs[i]};
            }
        }

        foreach(List<string> item in dict.Values)
        {
            result.Add(item);
        }

        return result;
    }
}
