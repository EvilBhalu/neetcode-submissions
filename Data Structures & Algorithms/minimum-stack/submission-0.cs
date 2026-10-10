public class MinStack {

    internal Stack<int> st;
    internal Stack<int> minst;

    public MinStack() 
    {
        st = new();
        minst = new();
    }
    
    public void Push(int val) 
    {
        st.Push(val);

        if(minst.Count == 0 || val <= minst.Peek())
            minst.Push(val);
    }
    
    public void Pop() 
    {
        int val = st.Pop();
        
        if(val == minst.Peek())
            minst.Pop();
    }
    
    public int Top() 
    {
        return st.Peek();
    }
    
    public int GetMin() 
    {
        return minst.Peek();
    }
}
