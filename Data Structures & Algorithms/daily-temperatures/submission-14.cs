public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var stack = new Stack<int>();

        for(int i=0;i< temperatures.Length; i++)
        {
            if(stack.Count ==0 || temperatures [i]<= temperatures[stack.Peek()])
            {
                stack.Push(i);
            }
            else
            {
                int count = stack.Count;
                while(count >0)
                {
                    count--;
                    if(temperatures[i] > temperatures[stack.Peek()])
                    {
                        int indice = stack.Pop();
                        temperatures[indice] = i-indice;
                    }
                }
                stack.Push(i);
            }
        }

        int count1 = stack.Count;
        while(count1 >0)
        {
            count1--;
            int indice = stack.Pop();
            temperatures[indice] = 0;
        }
        return temperatures;
    }
}
