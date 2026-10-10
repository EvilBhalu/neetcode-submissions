public class Solution {
    public int EvalRPN(string[] tokens) 
    {
        List<string> ops = new List<string> () {"+", "-", "*", "/"};
        Stack<int> st = new();

        for(int i=0; i<tokens.Length; i++)
        {
            if (!ops.Contains(tokens[i]))
            {
                st.Push(int.Parse(tokens[i]));
            }
            else
            {
                int val1 = st.Pop();
                int val2 = st.Pop();
                switch (tokens[i])
                {
                case "+":
                    st.Push(val2 + val1);
                    break;

                case "*":
                    st.Push(val2 * val1);
                    break;
                case "-":
                    st.Push(val2 - val1);
                    break;
                case "/":
                    st.Push(val2 / val1);
                    break;
                }
            }
        }

        return st.Peek();    
    }
}
