public class Solution {

    Dictionary<int, int> memo = new();
    
    public int ClimbStairs(int n) 
    {     
        if (n <= 2)
            return n;

        if (memo.TryGetValue(n, out var found))
            return found;

        return memo[n] = ClimbStairs(n-1) + ClimbStairs(n-2);    
    }
}
