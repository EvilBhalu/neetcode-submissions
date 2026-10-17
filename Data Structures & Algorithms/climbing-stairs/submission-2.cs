public class Solution {

    // Dictionary<int, int> memo = new();
    
    // public int ClimbStairs(int n) 
    // {     
    //     if (n <= 2)
    //         return n;

    //     if (memo.TryGetValue(n, out var found))
    //         return found;

    //     return memo[n] = ClimbStairs(n-1) + ClimbStairs(n-2);    
    // }

    public int ClimbStairs(int n)
    {
        return Dp(n, new int[n+1]);
    }

    private int Dp(int n, int[] memo)
    {
        if (n <= 2)
            return n;

        if (memo[n] != 0)
            return memo[n];
        
        return memo[n] = Dp(n-1, memo) + Dp (n-2, memo);
    }
}
