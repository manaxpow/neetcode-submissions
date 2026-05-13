public class MinStack {
    private int _min;
    private int _cur;
    List<int> stack = new List<int>();
    public MinStack() {
        _min = int.MaxValue;
        _cur=-1;
    }
    
    public void Push(int val) {
        stack.Add(val);
        _cur++;
        _min = Math.Min(_min,val);
    }
    
    public void Pop() {
        if(stack[_cur] == _min)
        {
            stack.RemoveAt(_cur);
            _cur--;
            _min = int.MaxValue;
            foreach(int i in stack)
            {
                _min = Math.Min(_min,i);
            }
        }
        else
        {
            stack.RemoveAt(_cur);
            _cur--;
        }
    }
    
    public int Top() {
        return stack[_cur];
    }
    
    public int GetMin() {
        return _min;
    }
}
