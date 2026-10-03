public class Solution {
    public bool IsValid(string s) 
    {
        Stack<char> st = new Stack<char>();
        var arr = s.ToCharArray();

        if(arr.Length == 1)
        {
            return false;
        }

        for(int i=0; i<arr.Length; i++)
        {
            if (arr[i] == '(' || arr[i] == '{' || arr[i] == '[')
            {
                st.Push(arr[i]);
            }

            else if (arr[i] == ')' || arr[i] == '}' || arr[i] == ']')
            {
                if (st.Count() == 0)
                {
                    return false;
                }

                var ch = st.Pop();

                if (arr[i] == ')' && ch != '(' || arr[i] == '}' && ch != '{' || arr[i] == ']' && ch != '[')
                {
                    return false;
                }
            }
        }

        return st.Count() == 0 ? true : false;
    }
}
