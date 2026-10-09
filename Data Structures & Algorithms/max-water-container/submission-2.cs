public class Solution {
    public int MaxArea(int[] heights) 
    {
        // BRUTE FORCE SOLUTION
        // int maxA = 0;
        // for (int i=0; i<heights.Length-1; i++)
        // {
        //     for(int j=1; j<heights.Length; j++)
        //     {
        //         int curA = (j-i) * Math.Min(heights[i],heights[j]);
        //         Console.WriteLine(curA);
        //         if (curA > maxA)
        //             maxA = curA;
        //     }
        // }    
        // return maxA;

        int maxA = 0;
        int l = 0, r = heights.Length-1;

        while(l < r)
        {
            int curA = (r-l) * Math.Min(heights[l], heights[r]);
            if (curA > maxA)
                maxA = curA;

            if (heights[l] <= heights[r])
                l++;
            else
                r--;
        }
        return maxA;
    }
}
