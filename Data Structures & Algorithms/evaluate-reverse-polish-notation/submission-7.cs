public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<string>();
        foreach(string i in tokens)
        {
            if(i == "+" || i == "-" || i == "*" || i == "/")
            {
                int a = int.Parse(stack.Pop());
                int b = int.Parse(stack.Pop());
                
                switch (i)
                {
                    case "+":
                        stack.Push((b+a).ToString());
                        break;
                    case "-":
                        stack.Push((b-a).ToString());
                        break;
                    case "*":
                        stack.Push((b*a).ToString());
                        break;
                    case "/":
                        stack.Push((b/a).ToString());
                        break;
                }
            }
            else stack.Push(i);
        }
        
        return int.Parse(stack.Pop());
    }
}
