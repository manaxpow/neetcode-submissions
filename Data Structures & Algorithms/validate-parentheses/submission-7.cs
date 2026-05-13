public class Solution {
    public bool IsValid(string s) {
        var dict = new Dictionary<char,char>{
            { '{','}' }, 
            { '(',')' }, 
            { '[',']' }, 
        };
        var stack = new Stack<char>();
        foreach(char c in s)
        {
            if(stack.Count > s.Length/2 || (stack.Count > 0 && !dict.ContainsKey(stack.Peek()))) return false;

            if(stack.Count == 0 || dict[stack.Peek()] !=c )
            {
                stack.Push(c);
            }
            else
            {
                stack.Pop();
            }
        }

        if(stack.Count ==0)
            return true;
        return false;
    }
}
