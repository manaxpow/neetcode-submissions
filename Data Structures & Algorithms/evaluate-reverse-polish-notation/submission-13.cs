public class Solution {
    public int EvalRPN(string[] tokens) {
        var stack = new Stack<int>();
        foreach(string i in tokens)
        {
            if(Int32.TryParse(i,out int x))
            {
               stack.Push(x);
            }
            else 
            {
                int a = stack.Pop();
                int b = stack.Pop();
                
                switch (i)
                {
                    case "+":
                        stack.Push(b+a);
                        break;
                    case "-":
                        stack.Push(b-a);
                        break;
                    case "*":
                        stack.Push(b*a);
                        break;
                    case "/":
                        stack.Push(b/a);
                        break;
                }
            }
        }
        
        return stack.Peek();
    }
}
