public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();
        BackTracking(n,0,0,new List<char>(), result);
        return result;
    }

    private void BackTracking(int n, int open, int close,List<char> generate, List<string> result)
    {   
        if(open == n && close == n)
        {
            result.Add(new string(generate.ToArray()));
            return;
        }

        if(open < n)
        {
            generate.Add('(');
            BackTracking(n,open + 1,close, generate, result);
            generate.RemoveAt(generate.Count -1);
        }

        if(open > close || open == n)
        {
            generate.Add(')');
            BackTracking(n,open,close +1, generate, result);
            generate.RemoveAt(generate.Count -1);
        }
    }
}
